using System.Collections;
using System.Collections.Generic;
using LibraryManagementCourse.Data.Model;

namespace LibraryManagementCourse.ViewModel
{
    public class BookViewModel
    {
        public Book Book { get; set; }

        public IEnumerable<Author> Authors { get; set; }
    }
}