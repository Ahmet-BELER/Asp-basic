using Microsoft.AspNetCore.Mvc;
using basics.Models;
<<<<<<< HEAD
namespace basics.Controllers;


// course 

public class CourseController : Controller{

    // course/index
    public IActionResult Index()
=======




namespace basics.Controllers;

public class CourseController : Controller{

  public IActionResult Index()
>>>>>>> master
    {
        var kurs = new Course();
        kurs.Id = 1;
        kurs.Title = "Aspnet core kursu";
        kurs.Description = "new"; 
        kurs.Image = "asp.jpeg";
        return View(kurs);
        
    }

<<<<<<< HEAD
    //  course/List


    public IActionResult List()
{
    var kurslar = new List<Course>
    {
        new Course { Id = 1, Title = "asp kurs" , Description ="nice kurs" ,Image = "asp.jpeg"},
        new Course { Id = 2, Title = "django kurs" , Description ="nice kurs", Image = "dj.png"},
        new Course { Id = 3, Title = "js kurs" , Description ="nice kurs" , Image = "js.jpeg"},


    };

    return View("CourseList", kurslar);
}
    
}

=======
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




>>>>>>> master
