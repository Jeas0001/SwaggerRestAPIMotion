// See https://aka.ms/new-console-template for more information
using BLogic;
using Models;

Console.WriteLine("Hello, World!");
BusinessLogic businessLogic = new BusinessLogic();
List<Person> people = businessLogic.GetPeople();

foreach (Person person in people)
{
    Console.WriteLine(person.FirstName);
}
Console.ReadLine();