using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class WeightLoss
    {
        public int ID { get; set; }

        public double StartWeight { get; set; }

        public double NowWeight { get; set; }

        public DateTime LastEdited { get; set; }
    }
}
