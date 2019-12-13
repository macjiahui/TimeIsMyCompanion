using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeIsMyCompanion
{
    public partial class Form1 : Form
    {
        public SqlConnection Connection { get; }
        SqlDataReader reader;
        private DataContext dataContext;
        private Table<DOCTOR> doctorTable;
        private Table<EPISODE> episodeTable;
        private Table<COMPANION> companionTable;

        String connectionString = @"Data Source=.\SQLEXPRESS;Initial " +
                                   "Catalog=COMP10204_Lab5;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();

            try 
            {
                Connection = new SqlConnection();


                dataContext = new DataContext(Connection);

                doctorTable = dataContext.GetTable<DOCTOR>();
                episodeTable = dataContext.GetTable<EPISODE>();
                companionTable = dataContext.GetTable<COMPANION>();


                Connection.ConnectionString = connectionString;
                Connection.Open();
                statusLabel.Text = "Connected to Database Successfully";
                using (SqlCommand command = new SqlCommand("SELECT DOCTORID FROM DOCTOR", Connection)) {
                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string output = reader["DOCTORID"].ToString();
                            doctorComboBox.Items.Add(output);
                        }
                    }
                };
            }
            catch(Exception ex)
            {
                statusLabel.Text = "Database Connection failed - check Connection String: " + ex.Message;
            }
            
        }

        private void doctorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedDoctorID = doctorComboBox.SelectedItem.ToString();
            if (sqlRadioButton.Checked == true)
            {
                using (SqlCommand command = new SqlCommand($"SELECT * FROM DOCTOR " +
                                                            $"JOIN EPISODE " +
                                                            $"ON DOCTOR.DEBUT = EPISODE.STORYID " +
                                                            $"WHERE DOCTORID = {SelectedDoctorID}", Connection))
                {

                    using (reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            playedTextBox.Text = reader["ACTOR"].ToString();
                            yearTextBox.Text = reader["SEASONYEAR"].ToString();
                            seriesTextBox.Text = reader["SERIES"].ToString();
                            ageTextBox.Text = reader["AGE"].ToString();
                            episodeTextBox.Text = reader["TITLE"].ToString();

                            byte[] photo = (byte[])reader["PICTURE"];
                            MemoryStream stream = new MemoryStream(photo);
                            Image image = Image.FromStream(stream);
                            doctorPictureBox.Image = Image.FromStream(stream);

                        }
                    }
                };
                using (SqlCommand command = new SqlCommand($"SELECT NAME, ACTOR, TITLE, SEASONYEAR " +
                                                            $"FROM COMPANION c " +
                                                            $"JOIN EPISODE e " +
                                                            $"ON c.STORYID = e.STORYID " +
                                                            $"WHERE c.DOCTORID = {SelectedDoctorID} " +
                                                            $"ORDER BY SEASONYEAR", Connection))
                {
                    using (reader = command.ExecuteReader())
                    {
                        firstEpisodeTextBox.Clear();
                        while (reader.Read())
                        {
                            firstEpisodeTextBox.Text += $"{reader["NAME"].ToString()} ({reader["ACTOR"].ToString()}) " +
                                                        $"\r\n \"{reader["TITLE"].ToString()}\" ({reader["SEASONYEAR"].ToString()}) \r\n\r\n";
                        }
                    }
                }
            }
            else if (linqRadioButton.Checked == true)
            {
                Tuple<DOCTOR, EPISODE> tupleOne = (from doc in doctorTable 
                                                   join epi in episodeTable
                                                   on doc.DEBUT equals epi.STORYID
                                                   where doc.DOCTORID.ToString() == SelectedDoctorID
                                                   select new Tuple<DOCTOR, EPISODE> (doc, epi)
                                                   ).ToList().FirstOrDefault();

                playedTextBox.Text = tupleOne.Item1.ACTOR;
                yearTextBox.Text = tupleOne.Item2.SEASONYEAR.ToString();
                seriesTextBox.Text = tupleOne.Item1.SERIES.ToString();
                ageTextBox.Text = tupleOne.Item1.AGE.ToString();
                episodeTextBox.Text = tupleOne.Item2.TITLE.ToString();

                byte[] photo = tupleOne.Item1.PICTURE;
                MemoryStream stream = new MemoryStream(photo);
                Image image = Image.FromStream(stream);
                doctorPictureBox.Image = Image.FromStream(stream);

                string queryResult = (from com in companionTable 
                                        join epi in episodeTable
                                        on com.STORYID equals epi.STORYID
                                        where com.DOCTORID.ToString() == SelectedDoctorID
                                        orderby epi.SEASONYEAR
                                        select $"{com.NAME.ToString()} ({com.ACTOR.ToString()}) \r\n \'{epi.TITLE.ToString()}\' ({epi.SEASONYEAR}) \r\n\r\n"
                                        ).ToList().Aggregate((concat, str) => $"{concat}{str}");

                firstEpisodeTextBox.Text = queryResult;

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
