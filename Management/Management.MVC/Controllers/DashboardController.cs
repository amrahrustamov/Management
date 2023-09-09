using Management.Core.Entities;
using Management.DataAccess.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace Management.MVC.Controllers;

[Route("dashboard")]
public class DashboardController : Controller
{
    private readonly ManagementDbContext _context;

    public DashboardController(ManagementDbContext context)
    {
        _context = context;
    }

    [Route("{test}-index")]
    public IActionResult Index(string test)
    {
        object myValue = test;
        List<Department> list = _context.Departments.ToList();
        return View(myValue);
    }
}
