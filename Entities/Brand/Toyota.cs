using System.Collections.Generic;

public class Toyota : ICarBrand
{

    private string _type;
    private List<string> _types;
    public Toyota()
    {
        _type = "Toyota";
        _types = new List<string>();
        _types.Add("Allion");
        _types.Add("Corolla");
        _types.Add("Prado");
        _types.Add("Axio");
   
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