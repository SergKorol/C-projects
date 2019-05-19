using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementCourse.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using LibraryManagementCourse.Models;
using LibraryManagementCourse.ViewModel;

namespace LibraryManagementCourse.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly ICustomerRepository _customerRepository;

        public HomeController(IBookRepository bookRepository,
                              IAuthorRepository authorRepository,
                              ICustomerRepository customerRepository)
        {
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
            _customerRepository = customerRepository;
        }
        
        public IActionResult Index()
        {
            //create home view model
            var homeView = new HomeViewModel()
            {
                AuthorCount = _authorRepository.Count(x => true),
                CustomerCount = _customerRepository.Count(x => true),
                BookCount = _bookRepository.Count(x => true),
                LendBookCount = _bookRepository.Count(x => x.BorrowerId != 0)
            };
            
            return View(homeView);
        }

        
    }
}
