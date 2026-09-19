using Microsoft.AspNetCore.Mvc;
using ServiceContracts;
using ServiceContracts.DTO;

namespace ContactsManagerProject.Controllers
{
    public class PersonsController : Controller
    {
        private readonly IPersonsService _personsService;

        public PersonsController(IPersonsService personsService)
        {
            _personsService = personsService;
        }

        [Route("person/index")]
        [Route("/")]
        public IActionResult Index()
        {
            List<PersonResponse> persons = _personsService.GetAllPersons();

            return View(persons);// Views/Persons/index.cshtml
        }
    }
}
