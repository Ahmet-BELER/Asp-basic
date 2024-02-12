using Microsoft.AspNetCore.Mvc;
using basics.Models;
namespace basics.Controllers;


// course 

public class CourseController : Controller{

    // course/index
    public IActionResult Index()
    {
        var kurs = new Course();
        kurs.Id = 1;
        kurs.Title = "Aspnet core kursu";
        return View(kurs);
        
    }

    //  course/List


    
    public IActionResult List()
    {
        return View("CourseList");
    }
    
}

