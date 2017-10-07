using System.ComponentModel.DataAnnotations;

public class CarType
{
    [Key]
    public string Name { get; set; }
    [Required]
    public string VehicleType { get; set; }
    public string BodyType { get; set; }
    
    


    
    
}