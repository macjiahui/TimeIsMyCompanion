namespace TimeIsMyCompanion
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theDoctorGroupBox = new System.Windows.Forms.GroupBox();
            this.episodeTextBox = new System.Windows.Forms.TextBox();
            this.doctorPictureBox = new System.Windows.Forms.PictureBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.seriesTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.playedTextBox = new System.Windows.Forms.TextBox();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.firstEpisodeTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.queryGroupBox = new System.Windows.Forms.GroupBox();
            this.linqRadioButton = new System.Windows.Forms.RadioButton();
            this.sqlRadioButton = new System.Windows.Forms.RadioButton();
            this.statusLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.theDoctorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.queryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(806, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // theDoctorGroupBox
            // 
            this.theDoctorGroupBox.Controls.Add(this.episodeTextBox);
            this.theDoctorGroupBox.Controls.Add(this.doctorPictureBox);
            this.theDoctorGroupBox.Controls.Add(this.ageTextBox);
            this.theDoctorGroupBox.Controls.Add(this.seriesTextBox);
            this.theDoctorGroupBox.Controls.Add(this.yearTextBox);
            this.theDoctorGroupBox.Controls.Add(this.playedTextBox);
            this.theDoctorGroupBox.Controls.Add(this.doctorComboBox);
            this.theDoctorGroupBox.Controls.Add(this.label5);
            this.theDoctorGroupBox.Controls.Add(this.label6);
            this.theDoctorGroupBox.Controls.Add(this.label4);
            this.theDoctorGroupBox.Controls.Add(this.label3);
            this.theDoctorGroupBox.Controls.Add(this.label2);
            this.theDoctorGroupBox.Controls.Add(this.label1);
            this.theDoctorGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.theDoctorGroupBox.Location = new System.Drawing.Point(12, 27);
            this.theDoctorGroupBox.Name = "theDoctorGroupBox";
            this.theDoctorGroupBox.Size = new System.Drawing.Size(362, 397);
            this.theDoctorGroupBox.TabIndex = 1;
            this.theDoctorGroupBox.TabStop = false;
            this.theDoctorGroupBox.Text = "The Doctor";
            // 
            // episodeTextBox
            // 
            this.episodeTextBox.Location = new System.Drawing.Point(20, 365);
            this.episodeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.episodeTextBox.Name = "episodeTextBox";
            this.episodeTextBox.Size = new System.Drawing.Size(333, 23);
            this.episodeTextBox.TabIndex = 15;
            this.episodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // doctorPictureBox
            // 
            this.doctorPictureBox.Location = new System.Drawing.Point(177, 139);
            this.doctorPictureBox.Name = "doctorPictureBox";
            this.doctorPictureBox.Size = new System.Drawing.Size(175, 214);
            this.doctorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.doctorPictureBox.TabIndex = 11;
            this.doctorPictureBox.TabStop = false;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(104, 238);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.ReadOnly = true;
            this.ageTextBox.Size = new System.Drawing.Size(60, 23);
            this.ageTextBox.TabIndex = 10;
            // 
            // seriesTextBox
            // 
            this.seriesTextBox.Location = new System.Drawing.Point(104, 188);
            this.seriesTextBox.Name = "seriesTextBox";
            this.seriesTextBox.ReadOnly = true;
            this.seriesTextBox.Size = new System.Drawing.Size(60, 23);
            this.seriesTextBox.TabIndex = 9;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(104, 141);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.ReadOnly = true;
            this.yearTextBox.Size = new System.Drawing.Size(60, 23);
            this.yearTextBox.TabIndex = 8;
            // 
            // playedTextBox
            // 
            this.playedTextBox.Location = new System.Drawing.Point(104, 89);
            this.playedTextBox.Name = "playedTextBox";
            this.playedTextBox.ReadOnly = true;
            this.playedTextBox.Size = new System.Drawing.Size(239, 23);
            this.playedTextBox.TabIndex = 7;
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(104, 42);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(239, 25);
            this.doctorComboBox.TabIndex = 6;
            this.doctorComboBox.SelectedIndexChanged += new System.EventHandler(this.doctorComboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "First full episode:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Age at start:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Series:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Played by:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doctor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.firstEpisodeTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(380, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 397);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Companions and their first episode with this Doctor:";
            // 
            // firstEpisodeTextBox
            // 
            this.firstEpisodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstEpisodeTextBox.Location = new System.Drawing.Point(6, 35);
            this.firstEpisodeTextBox.Multiline = true;
            this.firstEpisodeTextBox.Name = "firstEpisodeTextBox";
            this.firstEpisodeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.firstEpisodeTextBox.Size = new System.Drawing.Size(287, 348);
            this.firstEpisodeTextBox.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(685, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 193);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // queryGroupBox
            // 
            this.queryGroupBox.Controls.Add(this.linqRadioButton);
            this.queryGroupBox.Controls.Add(this.sqlRadioButton);
            this.queryGroupBox.Location = new System.Drawing.Point(682, 251);
            this.queryGroupBox.Name = "queryGroupBox";
            this.queryGroupBox.Size = new System.Drawing.Size(119, 100);
            this.queryGroupBox.TabIndex = 13;
            this.queryGroupBox.TabStop = false;
            this.queryGroupBox.Text = "Query";
            // 
            // linqRadioButton
            // 
            this.linqRadioButton.AutoSize = true;
            this.linqRadioButton.Location = new System.Drawing.Point(14, 50);
            this.linqRadioButton.Name = "linqRadioButton";
            this.linqRadioButton.Size = new System.Drawing.Size(108, 17);
            this.linqRadioButton.TabIndex = 1;
            this.linqRadioButton.TabStop = true;
            this.linqRadioButton.Text = "Solve using LINQ";
            this.linqRadioButton.UseVisualStyleBackColor = true;
            // 
            // sqlRadioButton
            // 
            this.sqlRadioButton.AutoSize = true;
            this.sqlRadioButton.Checked = true;
            this.sqlRadioButton.Location = new System.Drawing.Point(14, 27);
            this.sqlRadioButton.Name = "sqlRadioButton";
            this.sqlRadioButton.Size = new System.Drawing.Size(104, 17);
            this.sqlRadioButton.TabIndex = 0;
            this.sqlRadioButton.TabStop = true;
            this.sqlRadioButton.Text = "Solve using SQL";
            this.sqlRadioButton.UseVisualStyleBackColor = true;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(14, 429);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(22, 13);
            this.statusLabel.TabIndex = 14;
            this.statusLabel.Text = "OK";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 450);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.queryGroupBox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.theDoctorGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.theDoctorGroupBox.ResumeLayout(false);
            this.theDoctorGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.queryGroupBox.ResumeLayout(false);
            this.queryGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox theDoctorGroupBox;
        private System.Windows.Forms.PictureBox doctorPictureBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox seriesTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox playedTextBox;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox firstEpisodeTextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox queryGroupBox;
        private System.Windows.Forms.RadioButton linqRadioButton;
        private System.Windows.Forms.RadioButton sqlRadioButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox episodeTextBox;
    }
}

