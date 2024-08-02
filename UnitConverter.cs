public class UnitConverter
{
    private int ratio;

    public UnitConverter(int unitRatio)     // Constructor
    {
        ratio = unitRatio;
    }

    public int Convert(int unit)        // Method
    {
        return unit * ratio;
    }
}

