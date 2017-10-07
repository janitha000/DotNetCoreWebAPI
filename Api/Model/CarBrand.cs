using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class CarBrand 
{
    [Key]
    public string Name {get; set;}
    [Required]
    public string Country { get; set; }
    public List<CarType> Types { get; set; }
}