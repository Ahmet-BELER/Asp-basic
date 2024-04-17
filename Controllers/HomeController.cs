<<<<<<< HEAD
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using basics.Models;

namespace basics.Controllers;

public class HomeController : Controller
{


    public IActionResult Index()
    {
        return View() ;
    }

    public IActionResult Contact()
    {
        return View() ;
    }


}
=======
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Courseapp.Models;

namespace Courseapp.Controllers;

public class HomeController : Controller
{
     public IActionResult Index()
    {
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

      public IActionResult Privacy()
    {
        return View();
    }

}
  
>>>>>>> master
