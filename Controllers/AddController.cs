using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Authorize(Roles = "admin")]
public class AddController : Controller
{
    private readonly AppDbContext _context;

    public AddController(AppDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Site site)
    {
        if (ModelState.IsValid)
        {
            _context.MasterSiteList.Add(site);
            _context.SaveChanges();
            return RedirectToAction("Index", "Site");
        }
        return View(site);
    }
}
