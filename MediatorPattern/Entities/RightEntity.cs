using System.ComponentModel.DataAnnotations.Schema;

namespace MediatorPattern.Entities;

[Table("Rights", Schema = "dbo")]
public class RightEntity
{
    public long Id { get; set; }
    public string Email { get; set; } = null!;
    public bool DriverLicence { get; set; } 
    public bool Vote { get; set; } 
    public bool DrinkAlcohol { get; set; } 
}
