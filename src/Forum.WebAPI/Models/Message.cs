using System.ComponentModel.DataAnnotations.Schema;

namespace Forum.WebAPI.Models;

[Table("Message")]
public class Message
{
    public int ID { get; set; }
    
    [Column("FK_Author")] 
    public int FkAuthor { get; set; }
    
    [Column("FK_Theme")]
    public int FkTheme { get; set; }
    
    public string MessageText { get; set; }
    public DateTime CreationDate { get; set; }
}