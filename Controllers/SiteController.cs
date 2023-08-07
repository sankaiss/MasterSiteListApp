using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

public class SiteController : Controller
{
    private readonly AppDbContext _context;

    public SiteController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var sites = _context.MasterSiteList.ToList();
        return View(sites);
    }

    // Implementera kod för att lägga till, ändra och radera rader här.
    // Detaljerade steg finns nedan.
}
