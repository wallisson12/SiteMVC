using Microsoft.AspNetCore.Mvc;
using SiteMvc.Controllers;
using SiteMvc.Models;
using SiteMvc.Repository;

namespace SiteMvc.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactRepository _contactRepository;

        public ContactController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        //Get Functions - view
        public IActionResult Index()
        {
           List<ContactModel> contacts =  _contactRepository.SearchAll();
            return View(contacts);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult DeleteConfirm()
        {
            return View();
        }

        //Post Functions - Information
        [HttpPost]
        public IActionResult Create(ContactModel contact)
        {
            _contactRepository.ToAdd(contact);
            return RedirectToAction("Index");
        }
    }
}
