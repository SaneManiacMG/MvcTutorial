using Microsoft.AspNetCore.Mvc;

namespace MvcTutorial.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is my default action";
        }

        public string Welcome()
        {
            return "This is the welcome method";
        }
    }
}
