using Microsoft.AspNetCore.Mvc;

namespace First_Proj
{
    public class HomeController : Controller
    {
        // Request
        // localhost: 5000/
        [HttpGet("")]
        public ViewResult Index()
        {
            // looks for File called Views/Home/Index.cshtml 
            return View();
        }

        // localhost: 5000/projects
        [HttpGet("projects")]
        public string Projects()
        {
            return "These are my projects";
        }
        // localhost: 5000/contact
        [HttpGet("contact")]
        public string Contact()
        {
            return "This is my contact!";
        }
    }
}