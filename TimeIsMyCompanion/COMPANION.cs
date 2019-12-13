using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeIsMyCompanion
{
    [Table(Name = "COMPANION")]
    class COMPANION
    {
        [Column]
        public string NAME { get; set; }
        [Column]
        public string ACTOR { get; set; }
        [Column]
        public int DOCTORID { get; set; }
        [Column]
        public string STORYID { get; set; }
    }
}
