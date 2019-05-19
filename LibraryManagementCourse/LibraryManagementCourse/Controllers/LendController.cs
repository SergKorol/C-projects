using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Xml.Linq;
using LibraryManagementCourse.Data.Interfaces;
using LibraryManagementCourse.ViewModel;
using LibraryManagementCourse.Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementCourse.Controllers
{
    public class LendController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly ICustomerRepository _customerRepository;

        public LendController(IBookRepository bookRepository, ICustomerRepository customerRepository)
        {
            _bookRepository = bookRepository;
            _customerRepository = customerRepository;
        }

        [Route("Lend")]
        public IActionResult List()
        {
            //load all available books
            var availableBooks = _bookRepository.FindWithAuthor(x => x.BorrowerId == 0);
            //check collection
            if (availableBooks.Count() == 0)
            {
                return View("Empty");
            }
            else
            {
                return View(availableBooks);
            }
        }

        public IActionResult LendBook(int bookId)
        {
            var lendVM = new LendViewModel
            {
                Book = _bookRepository.GetById(bookId),
                Customers = _customerRepository.GetAll()
            };

            return View(lendVM);
        }


        [HttpPost]
        public IActionResult LendBook(LendViewModel lendViewModel)
        {
            var book = _bookRepository.GetById(lendViewModel.Book.BookId);
            var customer = _customerRepository.GetById(lendViewModel.Book.BorrowerId);

                book.Borrower = customer;

            _bookRepository.Update(book);

            return RedirectToAction("List");
        }

    }
}