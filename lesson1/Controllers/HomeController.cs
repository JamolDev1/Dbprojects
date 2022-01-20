using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using lesson1.Models;
using lesson1.Data;
using lesson1.Entities;

namespace lesson1.Controllers;

public class HomeController : Controller
{
    private readonly Lesson1Db _database;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger, Lesson1Db database)
    {
        _database = database;
        _logger = logger;
    }

    
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult ShowDb()
    {
        var accounts = _database.AccountDb.ToList();
        var accountsMod = new AccountsModel()
        {
            Accounts = accounts
        };
        return View(accountsMod);
    }
    [HttpGet("welcome")]
    public IActionResult Welcome()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(AccountModel account)
    {
        var accountEntity = new Account()
        {
            Id = Guid.NewGuid(),
            Name = account.Name,
            UserName = account.UserName,
            Phone = account.Phone,
            Age = account.Age,
            Password = account.Password
        };
        _database.AccountDb.Add(accountEntity);
        _database.SaveChanges();
        return RedirectToAction("ShowDb");
    }   

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}