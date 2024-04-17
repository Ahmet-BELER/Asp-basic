using Microsoft.AspNetCore.Mvc;
using basics.Models;




namespace basics.Controllers;

public class CourseController : Controller{

  public IActionResult Index()
    {
        var kurs = new Course();
        kurs.Id = 1;
        kurs.Title = "Aspnet core kursu";
        kurs.Description = "new"; 
        kurs.Image = "asp.jpeg";
        return View(kurs);
        
    }

  public IActionResult Details(int id)
    {
    
        var kurs = Repository.GetById(id);
        return View(kurs);
    } 


    public IActionResult List()
    {
        return View("CourseList", Repository.Courses);
    }
  
  
}




