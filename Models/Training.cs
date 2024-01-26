using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Training
    {
        public int ID { get; set; }

        public DateTime TimeStart { get; set; }

        public DateTime TimeEnd { get; set; }

        public List<int> PartnerID { get; set; }

        public GeoLocation GeoLocation { get; set; }

        public Rating Rating { get; set; }
    }
}
