using CShap_ConsoleApp;

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