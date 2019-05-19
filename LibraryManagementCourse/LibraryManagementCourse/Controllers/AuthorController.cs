using System;
using System.Linq;
using LibraryManagementCourse.Data.Interfaces;
using LibraryManagementCourse.Data.Model;
using LibraryManagementCourse.ViewModel;
using Microsoft.AspNetCore.Http.Headers;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementCourse.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        [Route("Author")]
        public IActionResult List()
        {
            var authors = _authorRepository.GetAllWithBooks();

            if (!authors.Any())
            {
                return View("Empty");
            }

            return View(authors);
        }

        
        public IActionResult Update(int id)
        {
            var author = _authorRepository.GetById(id);
            if (author == null)
            {
                return NotFound();
            }

            return View(author);
        }

        [HttpPost]
        public IActionResult Update(Author author)
        {
            if (!ModelState.IsValid)
            {
                return View(author);
            }
            
            _authorRepository.Update(author);
            return RedirectToAction("List");
        }

        public ViewResult Create()
        {
            return View(new CreateAuthorViewModel { Referer = Request.Headers["Referer"].ToString() });
        }
        [HttpPost]
        public IActionResult Create(CreateAuthorViewModel authorVM)
        {
            if (!ModelState.IsValid)
            {
                return View(authorVM);
            }

            _authorRepository.Create(authorVM.Author);

            if (!String.IsNullOrEmpty(authorVM.Referer))
            {
                return Redirect(authorVM.Referer);
            }

            return RedirectToAction("List");
        }


        public IActionResult Delete(int id)
        {
            var customer = _authorRepository.GetById(id);

            _authorRepository.Delete(customer);

            return RedirectToAction("List");
        }

        

    }
}