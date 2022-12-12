using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Forum.WebAPI.Models;

[Table("Theme")]
public class Theme
{
    public int ID { get; set; }
    
    [Column("FK_Author")]
    public int FkAuthor { get; set; }   
    
    public string Tittle { get; set; }
    public DateTime CreationDate { get; set; }
}