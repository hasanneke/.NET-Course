using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PartyInviter.Models;

namespace PartyInviter.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View("MyView");
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult ListResponses()
    {
        return View();
    }

    [HttpGet]
    public IActionResult RsvpForm()
    {
        return View();
    }
    [HttpPost]
    public ViewResult RsvpForm(GuestResponse guestResponse)
    {
        if (guestResponse.WillAttend ?? false)
        {
            Repository.AddResponse(guestResponse);
        }
        return View("Thanks", guestResponse);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
