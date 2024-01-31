using DBAccess;
using Models;

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
    }
}