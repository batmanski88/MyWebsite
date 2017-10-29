using Microsoft.AspNetCore.Mvc;
using MyWebsite.Models;
using MyWebsite.Services;

namespace MyWebsite.ViewComponents
{
    public class ContactViewComponent : ViewComponent
    {
        private readonly IContactService _contactService;

        public ContactViewComponent(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IViewComponentResult Invoke(Contact contact)
        {
            _contactService.SendEmail(contact);
            return View(contact);
        }
    }
}