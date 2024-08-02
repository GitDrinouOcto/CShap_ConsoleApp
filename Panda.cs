namespace CShap_ConsoleApp;

public class Panda
{
    public string Name;             // Instance
    public static int Population;   // Static

    public Panda (string n)
    {
        Name = n;
        Population = Population + 1;
    }
}