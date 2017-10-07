using System.Collections.Generic;

public interface ICarBrand
{
    string GetBrand();
    IEnumerable<string> GetTypes();

    void Add(string type);

}
