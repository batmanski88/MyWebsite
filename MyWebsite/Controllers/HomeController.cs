using Microsoft.AspNetCore.Mvc;
using MyWebsite.Models;
using MyWebsite.Services;

namespace MyWebsite.Controllers
{
    public class HomeController : Controller
    {

        private readonly IContactService _contactService;

        public HomeController(IContactService contactService)
        {
            _contactService = contactService;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([FromForm]Contact contact)
        {
            if(ModelState.IsValid)
            {
                _contactService.SendEmail(contact);
            }

            return View();
        }
    }
}