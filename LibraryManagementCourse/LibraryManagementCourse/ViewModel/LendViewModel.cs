using System.Collections.Generic;
using LibraryManagementCourse.Data.Model;

namespace LibraryManagementCourse.ViewModel
{
    public class LendViewModel
    {
        public Book Book { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
    }
}