using System.ComponentModel.DataAnnotations.Schema;

namespace MediatorPattern.Entities;

[Table("People", Schema = "dbo")]
public class PersonEntitiy 
{
    public long Id { get; set; }
    public string Name { get; set; } = null!;
    public int Age { get; set; }
    public string Email { get; set; } = null!;
}
