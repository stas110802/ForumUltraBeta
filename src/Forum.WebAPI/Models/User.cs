using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Forum.WebAPI.Models;

[Table("User")]
public class User
{
    [JsonIgnore]
    public int ID { get; set; }
    
    public string Login { get; set; }
    
    [Column("Password")] 
    public string HashPassword { get; set; }
}