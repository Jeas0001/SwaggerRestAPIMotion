using DBAccess;
using Models;
using System.Security.Cryptography;
using System.Text;

namespace BLogic
{
    public class BusinessLogic
    {
        Backend Backend;

        public BusinessLogic()
        {
            Backend = new Backend();
        }

        public List<Person> GetPeople()
        {
            return Backend.GetPeople();
        }

        public Person GetPerson(int id)
        {
            return Backend.GetPerson(id);
        }

        public bool AddPerson(Person person)
        {
            return Backend.AddPerson(person);
        }

        public bool DeletePerson(int id)
        {
            return Backend.DeletePerson(id);
        }

        public bool UpdatePerson(int id, Person person)
        {
            return Backend.EditPerson(id, person);
        }

        public List<User> GetUsers()
        {
            var people = Backend.GetPeople();
            var users = new List<User>();
            foreach (var person in people)
            {
                users.Add(person.User);
            }
            return users;
        }

        public User GetUser(string username)
        {
            var users = GetUsers();
            foreach (var user in users)
            {
                if (user.UserName == username)
                {
                    return user;
                }
            }
            return new User();
        }

        public bool Login(string username, string password)
        {
            var user = GetUser(username);
            if (user.UserName == null)
            {
                return false;
            }
            string verify = VerifyPassword(password, user.Salt);
            var saltedPassword = verify.Split(':');
            if (saltedPassword[0] == user.Password)
            {
                return true;
            }
            return false;
        }

        public static string HashPassword(string password)
        {
            // Generate a random salt
            byte[] salt = GenerateSalt();

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] saltedPassword = new byte[passwordBytes.Length + salt.Length];
                Buffer.BlockCopy(passwordBytes, 0, saltedPassword, 0, passwordBytes.Length);
                Buffer.BlockCopy(salt, 0, saltedPassword, passwordBytes.Length, salt.Length);

                byte[] hashBytes = sha256.ComputeHash(saltedPassword);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }

                sb.Append(":");
                foreach (byte s in salt)
                {
                    sb.Append(s.ToString("x2"));
                }

                return sb.ToString();
            }
        }

        public static string VerifyPassword(string password, string salt)
        {

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] saltBytes = StringToByteArray(salt);

                byte[] saltedPassword = new byte[passwordBytes.Length + saltBytes.Length];
                Buffer.BlockCopy(passwordBytes, 0, saltedPassword, 0, passwordBytes.Length);
                Buffer.BlockCopy(saltBytes, 0, saltedPassword, passwordBytes.Length, saltBytes.Length);

                byte[] hashBytes = sha256.ComputeHash(saltedPassword);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }

                sb.Append(":");
                foreach (byte s in saltBytes)
                {
                    sb.Append(s.ToString("x2"));
                }

                return sb.ToString();
            }
        }

        static byte[] StringToByteArray(string hex)
        {
            int numberChars = hex.Length;
            byte[] bytes = new byte[numberChars / 2];
            for (int i = 0; i < numberChars; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }
            return bytes;
        }

        static byte[] GenerateSalt()
        {
            // Generate a random salt using a cryptographic random number generator
            byte[] salt = new byte[16];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }
    }

}
