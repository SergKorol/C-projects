using System;
using System.Collections.Generic;
using LibraryManagementCourse.Data.Interfaces;
using LibraryManagementCourse.Data.Model;
using LibraryManagementCourseModel.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace LibraryManagementCourse.Data.Repository
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(LibraryDbContext context) : base(context)
        {
        }

        public IEnumerable<Book> FindWithAuthor(Func<Book, bool> predicate)
        {
            return _context.Books.Include(a => a.Author).Where(predicate);
        }

        public IEnumerable<Book> FindWithAuthorAndBorrower(Func<Book, bool> predicate)
        {
            return _context.Books.Include(a => a.Author).Include(a => a.Borrower).Where(predicate);
        }

        public IEnumerable<Book> GetAllWithAuthor()
        {
            return _context.Books.Include(a => a.Author);
        }
    }
}
