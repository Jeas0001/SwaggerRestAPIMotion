using System.Xml.Serialization;

namespace Models
{
    public class User
    {
        public int ID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Salt { get; set; }

        public bool IsAdmin { get; set; }

        public string Email { get; set; }
    }
}