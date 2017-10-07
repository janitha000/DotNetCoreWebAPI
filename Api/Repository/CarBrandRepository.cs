using System.Linq;

public class CarBrandRepositoryand : IRepository<CarBrand>
{
    public void AddData(CarBrand data)
    {
        using (CarDbContext context = new CarDbContext())
        {
            context.CarBrand.Add(data);
            context.SaveChanges();
        }
    }

    public CarBrand GetData(string name)
    {
        using (CarDbContext context = new CarDbContext())
        {
            CarBrand brand = context.CarBrand.FirstOrDefault(carbrand => carbrand.Name == name);
            return brand;
        }
    }

    public void Update(CarBrand data)
    {
        throw new System.NotImplementedException();
    }
}