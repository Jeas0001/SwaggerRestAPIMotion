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
    }
}