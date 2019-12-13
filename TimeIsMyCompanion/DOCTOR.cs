using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeIsMyCompanion
{
    [Table(Name = "DOCTOR")]
    class DOCTOR
    {
        [Column]
        public int DOCTORID { get; set; }
        [Column]
        public string ACTOR { get; set; }
        [Column]
        public int SERIES { get; set; }
        [Column]
        public int AGE { get; set; }
        [Column]
        public string DEBUT { get; set; }
        [Column]
        public byte[] PICTURE { get; set; }
    }
}