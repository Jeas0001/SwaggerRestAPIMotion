// See https://aka.ms/new-console-template for more information
using BLogic;
using Models;
using Test.Tests;


Console.WriteLine("Running Tests");

BLTests.BusinessLogicGetPeopleReturnListOfPeople();
BLTests.BusinessLogicGetPersonReturnPerson();
BLTests.BusinessLogicAddPersonReturnBoleanTrue();
BLTests.BusinessLogicDeletePersonReturnBoleanTrue();
BLTests.BusinessLogicUpdatePersonReturnBoleanTrue();
