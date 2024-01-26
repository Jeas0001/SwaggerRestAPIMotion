using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Rating
    {
        public int ID { get; set; }

        public double RatingOutOfFive { get; set; }

        public string Comment { get; set; }
    }
}
