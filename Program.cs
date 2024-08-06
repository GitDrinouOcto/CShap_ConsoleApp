using System.Drawing;
using CShap_ConsoleApp;

/*
Console.WriteLine("---Basics-----------------------------");
Console.WriteLine(FeetToInches(30));
Console.WriteLine(FeetToInches(100));

int FeetToInches(int feet)
{
    int inches = feet * 12;
    return inches;
}

void SayHello()
{
    Console.WriteLine("Hello, world!");
}
SayHello();

Console.WriteLine("---INT & STRING-----------------------------");
// INT & STRING
string message = "JO de Paris ";
int y = 2024;
message = message.ToUpper() + y.ToString();
Console.WriteLine(message);

Console.WriteLine("---BOOLEAN-----------------------------");

// BOOLEAN
bool simpleVar = false;
if (simpleVar)
    Console.WriteLine("This will not print");

int num = 5000;
bool lessThanAMile = num < 5280;
if (lessThanAMile)
    Console.WriteLine("This will print");


Console.WriteLine("---CUSTOM TYPES-----------------------------");

// Custom types
UnitConverter feetToInchesConverter = new UnitConverter(12);
UnitConverter milesToFeetConverter = new UnitConverter(5280);

Console.WriteLine(feetToInchesConverter.Convert(30));
Console.WriteLine(feetToInchesConverter.Convert(100));
Console.WriteLine(feetToInchesConverter.Convert(milesToFeetConverter.Convert(1)));


Console.WriteLine("---INSTANCE & STATIC-----------------------------");

// Instance & Static
Panda p1 = new Panda("pan Dee");
Panda p2 = new Panda("Pan Dah");
Console.WriteLine(p1.Name);
Console.WriteLine(p2.Name);
Console.WriteLine(Panda.Population);

Console.WriteLine("---TYPES AND CONVERSIONS-----------------------------");
int valueInt = 123456;         // 32-bit integer
long valueLong = valueInt;             // convert to 64-bit integer
short valueShort = (short)valueInt;
Console.WriteLine("Entier: " + valueInt);
Console.WriteLine("Long: " + valueLong);
Console.WriteLine("Short: " + valueShort);


Console.WriteLine("---VALUE TYPES-----------------------------");
Point p1 = new Point();
p1.X = 7;
Point p2 = p1;
Console.WriteLine("P1 = " + p1.X);
Console.WriteLine("P2 = " + p2.X);

p1.X = 9;

Console.WriteLine("P1 = " + p1.X);
Console.WriteLine("P2 = " + p2.X);


Console.WriteLine("---OVERFLOW-----------------------------");
int x = int.MaxValue;
int y = unchecked(x + 1);

Console.WriteLine("x = " + x);
Console.WriteLine("y = " + y);
Console.WriteLine("w = " + unchecked(x + 1));
*/

Console.WriteLine("---NaN-----------------------------");
Console.WriteLine(0.0 / 0.0 == double.NaN);
Console.WriteLine(double.IsNaN(0.0 / 0.0));