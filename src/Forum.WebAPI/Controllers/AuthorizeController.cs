using Forum.WebAPI.Context;
using Forum.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Forum.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AuthorizeController
{
    private readonly ForumContext _db;

    public AuthorizeController()
    {
        _db = new ForumContext();
    }
    
    [HttpPost(template:"register")]
    public string RegisterUser(User user)
    {
        var dbUser = _db.Users.Add(user).Entity;
        _db.SaveChanges();
        var token = GenerateToken();

        _db.UserTokens.Add(new UserToken
        {
            FkUser = dbUser.ID,
            Token = token
        });
        _db.SaveChanges();
        
        return token;
    }
    
    [HttpPost(template:"authorize")]
    public string? AuthorizeUser(User user)
    {
        var dbUser = _db.Users
            .FirstOrDefault(x => x.Login == user.Login && x.HashPassword == user.HashPassword);
        return dbUser == null ? 
            null : _db.UserTokens.FirstOrDefault(x => x.FkUser == dbUser.ID)?.Token;
    }

    private static string GenerateToken()
    {
        return Guid.NewGuid().ToString();
    }
}