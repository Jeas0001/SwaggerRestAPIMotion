using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public DateTime Birthday { get; set; }

        public int Height { get; set; }

        public PrimaryCity City { get; set; }

        public List<Training> Training { get; set; }

        public WeightLoss WeightLoss { get; set; }

        public User User { get; set; }
    }
}
