public class CarBrandManager
{
    public ICarBrand GetBrand(string type)
    {
        if (type.Equals("KIA"))
            return new KIA();
        else if (type.Equals("Toyota"))
            return new Toyota();
        else
            return null;
    }
}