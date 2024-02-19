// See https://aka.ms/new-console-template for more information
using BLogic;
using Models;
using Test.Tests;


//Console.WriteLine("Running Tests");

//BLTests.BusinessLogicGetPeopleReturnListOfPeople();
//BLTests.BusinessLogicGetPersonReturnPerson();
//BLTests.BusinessLogicAddPersonReturnBoleanTrue();
//BLTests.BusinessLogicDeletePersonReturnBoleanTrue();
//BLTests.BusinessLogicUpdatePersonReturnBoleanTrue();
int i = 1;
int x = 0;

for (int i2 = 0; i2 < 100000000; i2++)
{
	try
	{
        Console.WriteLine(i++);
        string test = BusinessLogic.HashPassword("Password");
        //Console.WriteLine(test);
        var test2 = test.Split(':');
        string verifyTest = BusinessLogic.VerifyPassword("Password", test2[1]);
        //Console.WriteLine(verifyTest);
        if (test == verifyTest) { x++; }
    }
	catch (Exception e)
	{
        Console.WriteLine(e);
        Console.ReadLine();
        throw;
	}
    
}

Console.WriteLine($"It sucecced {x} times");
