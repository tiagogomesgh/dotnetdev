// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please Enter Your Full Name.");
string fullName = Console.ReadLine();
string[]splitNames = fullName.Split(" ");
Console.WriteLine($"User Information: First Name: {splitNames[0]} Last Name: {splitNames[1]}");

