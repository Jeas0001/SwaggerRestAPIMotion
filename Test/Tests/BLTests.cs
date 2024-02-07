using BLogic;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Tests
{
    public class BLTests
    {
        public static void BusinessLogicGetPeopleReturnListOfPeople()
        {
            try
            {
                Console.WriteLine();
                BusinessLogic bLogic = new BusinessLogic();

                List<Person> result = bLogic.GetPeople();

                if (result != null)
                {
                    Console.WriteLine("Passed: bLogic.GetPeople");
                }
                else
                {
                    Console.WriteLine("Failed: bLogic.GetPeople");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static void BusinessLogicGetPersonReturnPerson()
        {
            try
            {
                Console.WriteLine();
                BusinessLogic bLogic = new BusinessLogic();

                Person result = bLogic.GetPerson(1);

                if (result != null)
                {
                    Console.WriteLine("Passed: bLogic.GetPerson");
                }
                else
                {
                    Console.WriteLine("Failed: bLogic.GetPerson");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static void BusinessLogicAddPersonReturnBoleanTrue()
        {
            try
            {
                Console.WriteLine();
                BusinessLogic bLogic = new BusinessLogic();

                var result = bLogic.AddPerson(new Person());

                if (result == true)
                {
                    Console.WriteLine("Passed: bLogic.AddPerson");
                }
                else
                {
                    Console.WriteLine("Failed: bLogic.AddPerson");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static void BusinessLogicDeletePersonReturnBoleanTrue()
        {
            try
            {
                Console.WriteLine();
                BusinessLogic bLogic = new BusinessLogic();

                var result = bLogic.DeletePerson(1);

                if (result == true)
                {
                    Console.WriteLine("Passed: bLogic.DeletePerson");
                }
                else
                {
                    Console.WriteLine("Failed: bLogic.DeletePerson");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static void BusinessLogicUpdatePersonReturnBoleanTrue()
        {
            try
            {
                Console.WriteLine();
                BusinessLogic bLogic = new BusinessLogic();

                var result = bLogic.UpdatePerson(1, new Person());

                if (result == true)
                {
                    Console.WriteLine("Passed: bLogic.UpdatePerson");
                }
                else
                {
                    Console.WriteLine("Failed: bLogic.UpdatePerson");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
