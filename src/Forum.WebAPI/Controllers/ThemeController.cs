using Forum.WebAPI.Context;
using Forum.WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Forum.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ThemeController
{
    private readonly ForumContext _db;

    public ThemeController()
    {
        _db = new ForumContext();
    }
    
    [HttpGet(template:"getAllThemes")]
    public IEnumerable<Theme> GetAllThemes()
    {
        return _db.Themes.ToList();
    }
}