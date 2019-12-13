using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace TimeIsMyCompanion
{
    [Table(Name = "EPISODE")]
    class EPISODE
    {
        [Column]
        public string STORYID { get; set; }
        [Column]
        public int SEASON { get; set; }
        [Column]
        public int SEASONYEAR { get; set; }
        [Column]
        public string TITLE { get; set; }
    }
}
