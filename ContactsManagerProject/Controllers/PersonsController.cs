using Microsoft.AspNetCore.Mvc;

namespace ContactsManagerProject.Controllers
{
    public class PersonsController : Controller
    {
        [Route("person/index")]
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
