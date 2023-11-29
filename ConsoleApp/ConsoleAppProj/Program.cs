// See https://aka.ms/new-console-template for more information
/// <summary>
///  This is a console application, designed to refamiliarize myself with C# and its capabilities.
///  I aim to design a program that will intake a JSON file of different vehicles and their model information,
///  sort this information into classes of vehicles, and display this in a chart. Listing mileage, year, make and model.
///
///  Without any research, Im first going to worry about the classes and object oriented side of things.
///  I will need classes for SUV, Truck, Coupe, & Sedan. I will also need a special instance class for Motorcycles.
///  Once the classes are constructed, Ill have to create a function to Sort the information from the JSON file,
///  according to the object classes properties. For example, Cars with 4 doors, and a Full Size frame, will be
///  categorized as SUVs, Cars with 4 doors, and a Medium Sized frame, will be categorized Sedans.
///  Trucks will have a special case of 2 or 4 doors, but will contain a boolean of (containsBed).
///  Coupes will be a small frame vehicle with only 2 doors.
/// </summary>

///////////////////////////////////////////////////////////////////////////////
//                                  Comment
//Refresher on C# Needed -
//* Variables and Instantiation
//* Methods and .NET 7 Changes
//* Classes , Constructors, and OOP.
///////////////////////////////////////////////////////////////////////////////
//                                   Warmup
//////////////////////////////////////////////////////////////////////////////
// Takes in a string, uses split Method to store and display the users full name.
///////////////////////////////////////////////////////////////////////////////
//Console.WriteLine("Please Enter Your Full Name.");
//string fullName = Console.ReadLine();
//string[]splitNames = fullName.Split(" ");
//Console.WriteLine($"User Information: First Name: {splitNames[0]} Last Name: {splitNames[1]}");
///////////////////////////////////////////////////////////////////////////////
// Using a Constructor, I created a very basic console application, that intakes
// properties of a vehicle, and stores them into individual variables.
//
// The next goal is to implement the input from a JSON file.
///////////////////////////////////////////////////////////////////////////////
/// Comment ///
/// Top Level Statements - Methods / Function Calls

/// <summary>
/// Created Car Class, fill object, display car information
/// </summary>

Car car1 = new Car("Silverado", "Chevy", "Silver", 2017);
Car car2 = new Car("Raptor", "Ford", "Black", 2023);
Car car3 = new Car("Ram", "Dodge", "Red", 2020);
void PrintStock()
{
    Console.WriteLine($"{car1.year} {car1.color} {car1.make} {car1.model}");
    Console.WriteLine($"{car2.year} {car2.color} {car2.make} {car2.model}");
    Console.WriteLine($"{car3.year} {car3.color} {car3.make} {car3.model}");
}



/// <summary>
/// Calculates the Area of a Circle based on a given radius.
/// </summary>

double AreaOfACircle(int radius)
{
  double result = Math.PI * Math.Pow(radius, 2);
  Console.WriteLine(result);
  return result;
}



/// FUNCTION CALLS
// ------------------------------------
AreaOfACircle(12);
PrintStock();


// ------------------------------------



//--------------------------------------------------------
/// Comment ///
/// Bottom Level Statements - Classes
public class Car
{
    public int year;
    public string model;
    public string make;
    public string color;

    /// <summary>
    /// Constructor for Car Object.
    /// </summary>
    public Car(string model, string make, string color, int year)
    {
        this.make = make;
        this.model = model;
        this.year = year;
        this.color = color;
    }
}
