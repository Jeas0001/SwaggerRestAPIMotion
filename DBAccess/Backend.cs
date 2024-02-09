using Models;
using System.Text.Json;

namespace DBAccess
{
    public class Backend
    {
        static List<Person> people;
        public Backend()
        {
            people = new List<Person>();
            DummyData();
        }

        public List<Person> GetPeople()
        {
            return people;
        }

        public Person GetPerson(int id)
        {
            foreach (Person person in people)
            {
                if (person.ID == id)
                {
                    return person;
                }
            }
            return new Person();
        }

        public bool AddPerson(Person person)
        {
            try
            {
                people.Add(person);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool EditPerson(int id, Person person)
        {
            try
            {
                foreach (Person people1 in people)
                {
                    if (people1.ID == id)
                    {
                        people[people.IndexOf(people1)] = person;
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool DeletePerson(int id)
        {
            try
            {
                foreach (Person person in people)
                {
                    if (person.ID == id)
                    {
                        people.RemoveAt(people.IndexOf(person));
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }














        public static void DummyData()
        {

            // Person 1
            Person person1 = new Person
            {
                ID = 1,
                FirstName = "John",
                LastName = "Doe",
                Gender = "Male",
                Birthday = DateTime.Parse("1990-05-15T00:00:00"),
                Height = 175,
                City = new PrimaryCity
                {
                    ID = 1,
                    City = "Silkeborg",
                    PostAddress = 8600
                },
                Training = new List<Training>
                {
                    new Training
                    {
                        ID = 1,
                        TimeStart = DateTime.Parse("2024-01-29T08:00:00"),
                        TimeEnd = DateTime.Parse("2024-01-29T09:30:00"),
                        PartnerID = new List<int> { 2, 3 },
                        GeoLocation = new GeoLocation
                        {
                            ID = 1,
                            Latitude = 37.7749,
                            Longitude = -122.4194
                        },
                        Rating = new Rating
                        {
                            ID = 1,
                            RatingOutOfFive = 4.5,
                            Comment = "Great session!"
                        }
                    },
                    // Add more training sessions as needed
                },
                WeightLoss = new WeightLoss
                {
                    ID = 1,
                    StartWeight = 120,
                    NowWeight = 100,
                    LastEdited = DateTime.Parse("1990-05-15T00:00:00")
                },
                User = new User
                {
                    ID = 1,
                    UserName = "johndoe123",
                    Password = "b1996741837a238b3f7dbc6270ed4ceedde524377ca1125da665ca5f1f0543ee",
                    Salt = "8cbbe2b5af436afb56d66e0fb734112f",
                    IsAdmin = true,
                    Email = "john.doe@example.com"
                }
            };

            people.Add(person1);

            // Person 2
            Person person2 = new Person
            {
                ID = 2,
                FirstName = "Alice",
                LastName = "Smith",
                Gender = "Female",
                Birthday = DateTime.Parse("1995-08-22T00:00:00"),
                Height = 160,
                City = new PrimaryCity
                {
                    ID = 2,
                    City = "Copenhagen",
                    PostAddress = 1000
                },
                Training = new List<Training>
            {
                new Training
                {
                    ID = 3,
                    TimeStart = DateTime.Parse("2024-01-30T10:00:00"),
                    TimeEnd = DateTime.Parse("2024-01-30T11:30:00"),
                    PartnerID = new List<int> { 4, 5 },
                    GeoLocation = new GeoLocation
                    {
                        ID = 3,
                        Latitude = 55.6761,
                        Longitude = 12.5683
                    },
                    Rating = new Rating
                    {
                        ID = 3,
                        RatingOutOfFive = 4.2,
                        Comment = "Enjoyable workout!"
                    }
                },
                // Add more training sessions as needed
            },
                WeightLoss = new WeightLoss
                {
                    ID = 2,
                    StartWeight = 140,
                    NowWeight = 130,
                    LastEdited = DateTime.Parse("1995-08-22T00:00:00")
                },
                User = new User
                {
                    ID = 2,
                    UserName = "alicesmith456",
                    Password = "e2f10c7332eccb17268c3f62e6bffaa17554bf156ca9b520f0f6619d0c7705f9",
                    Salt = "5ee546063bcb6b5c638025141e6f0e3f",
                    IsAdmin = false,
                    Email = "alice.smith@example.com"
                }
            };

            people.Add(person2);

            // Person 3
            Person person3 = new Person
            {
                ID = 3,
                FirstName = "Michael",
                LastName = "Johnson",
                Gender = "Male",
                Birthday = DateTime.Parse("1985-12-10T00:00:00"),
                Height = 182,
                City = new PrimaryCity
                {
                    ID = 3,
                    City = "Aarhus",
                    PostAddress = 8000
                },
                Training = new List<Training>
            {
                new Training
                {
                    ID = 4,
                    TimeStart = DateTime.Parse("2024-01-31T15:30:00"),
                    TimeEnd = DateTime.Parse("2024-01-31T17:00:00"),
                    PartnerID = new List<int> { 6, 7 },
                    GeoLocation = new GeoLocation
                    {
                        ID = 4,
                        Latitude = 56.1629,
                        Longitude = 10.2039
                    },
                    Rating = new Rating
                    {
                        ID = 4,
                        RatingOutOfFive = 3.8,
                        Comment = "Good session, could improve."
                    }
                },
                // Add more training sessions as needed
            },
                WeightLoss = new WeightLoss
                {
                    ID = 3,
                    StartWeight = 180,
                    NowWeight = 170,
                    LastEdited = DateTime.Parse("1985-12-10T00:00:00")
                },
                User = new User
                {
                    ID = 3,
                    UserName = "michael1985",
                    Password = "2db9b4fc3455609862c6690b500e8b1d0d394f0fec4106898cefaf7a653a59cc",
                    Salt = "a8243aabf75f4d136be073ba4540051f",
                    IsAdmin = false,
                    Email = "michael.johnson@example.com"
                }
            };

            people.Add(person3);

            // Person 4
            Person person4 = new Person
            {
                ID = 4,
                FirstName = "Emily",
                LastName = "Davis",
                Gender = "Female",
                Birthday = DateTime.Parse("1992-04-05T00:00:00"),
                Height = 165,
                City = new PrimaryCity
                {
                    ID = 4,
                    City = "Odense",
                    PostAddress = 5000
                },
                Training = new List<Training>
            {
                new Training
                {
                    ID = 5,
                    TimeStart = DateTime.Parse("2024-02-01T12:00:00"),
                    TimeEnd = DateTime.Parse("2024-02-01T13:30:00"),
                    PartnerID = new List<int> { 8, 9 },
                    GeoLocation = new GeoLocation
                    {
                        ID = 5,
                        Latitude = 55.4038,
                        Longitude = 10.4024
                    },
                    Rating = new Rating
                    {
                        ID = 5,
                        RatingOutOfFive = 4.0,
                        Comment = "Fantastic workout!"
                    }
                },
                // Add more training sessions as needed
            },
                WeightLoss = new WeightLoss
                {
                    ID = 4,
                    StartWeight = 150,
                    NowWeight = 140,
                    LastEdited = DateTime.Parse("1992-04-05T00:00:00")
                },
                User = new User
                {
                    ID = 4,
                    UserName = "emilydavis92",
                    Password = "fdd4fefe371a627ef834cca6526b43fcfd23901471a59d31404df5d20c2f437c",
                    Salt = "3a968d106202f42db9b14688e1811db6",
                    IsAdmin = false,
                    Email = "emily.davis@example.com"
                }
            };

            people.Add(person4);

            // Person 5
            Person person5 = new Person
            {
                ID = 5,
                FirstName = "Daniel",
                LastName = "Brown",
                Gender = "Male",
                Birthday = DateTime.Parse("1988-09-18T00:00:00"),
                Height = 178,
                City = new PrimaryCity
                {
                    ID = 5,
                    City = "Horsens",
                    PostAddress = 8700
                },
                Training = new List<Training>
            {
                new Training
                {
                    ID = 6,
                    TimeStart = DateTime.Parse("2024-02-02T17:00:00"),
                    TimeEnd = DateTime.Parse("2024-02-02T18:30:00"),
                    PartnerID = new List<int> { 10, 11 },
                    GeoLocation = new GeoLocation
                    {
                        ID = 6,
                        Latitude = 55.8569,
                        Longitude = 9.8908
                    },
                    Rating = new Rating
                    {
                        ID = 6,
                        RatingOutOfFive = 4.2,
                        Comment = "Enjoyable workout!"
                    }
                },
                // Add more training sessions as needed
            },
                WeightLoss = new WeightLoss
                {
                    ID = 5,
                    StartWeight = 160,
                    NowWeight = 155,
                    LastEdited = DateTime.Parse("1988-09-18T00:00:00")
                },
                User = new User
                {
                    ID = 5,
                    UserName = "danielbrown88",
                    Password = "3d0f98863161e359e5c711f63f6ca6d6b9261897d497b3850c6fdd3f697b6b91",
                    Salt = "a6622a7a8cac84445be291dfad8a765d",
                    IsAdmin = false,
                    Email = "daniel.brown@example.com"
                }
            };

            people.Add(person5);

        }
    }
}