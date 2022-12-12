using System.ComponentModel.DataAnnotations.Schema;

namespace Forum.WebAPI.Models;

[Table("UserToken")]
public class UserToken
{
    public int ID { get; set; }
    
    [Column("FK_User")]
    public int FkUser { get; set; }

    public string Token { get; set; }
}