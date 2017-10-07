using System.Collections.Generic;

public class KIA : ICarBrand
{
    private string _type;
    private List<string> _types;
    public KIA()
    {
        _type = "KIA";
        _types = new List<string>();
        _types.Add("Optima");
        _types.Add("Cerato");
        _types.Add("Sorento");
        _types.Add("Sportage");
   
    }

    public void Add(string type)
    {
        _types.Add(type);
    }

    public string GetBrand()
    {
        string Type = _type;
        return Type;
    }

    public IEnumerable<string> GetTypes()
    {
        return _types;
    }
}