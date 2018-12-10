using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //Notes
        //? is URL is seperator and query string follows, & seperates query strings
        //Controller method generally returns IActionResult result 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View(); //Returns view object that generates html response
        }

        // 
        // GET: /HelloWorld/Welcome/ 

            //modifying url input 
        public IActionResult About()
        { 
            return View();
        }

       
    }
}
