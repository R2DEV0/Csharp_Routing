using Microsoft.AspNetCore.Mvc;

namespace First_Proj
{
    public class HomeController : Controller
    {
        // Request
        // localhost: 5000/
        [HttpGet("")]
        public string Index()
        {
            return "This is my Index!";
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