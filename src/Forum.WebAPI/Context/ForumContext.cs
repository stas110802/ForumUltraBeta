using Forum.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Forum.WebAPI.Context;

public class ForumContext : DbContext
{
    private readonly string _connectionString; 
    
    public ForumContext(string? connectionString = null)
    {
        _connectionString = connectionString 
                            ?? "Server=DESKTOP-HOARC76;Database=ForumDb;Trusted_Connection=True;;TrustServerCertificate=true;";
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Theme> Themes { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<UserToken> UserTokens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString);
    }
}