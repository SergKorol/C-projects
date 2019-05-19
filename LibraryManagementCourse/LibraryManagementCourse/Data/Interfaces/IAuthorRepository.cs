using System;
using System.Collections.Generic;
using LibraryManagementCourse.Data.Model;
using LibraryManagementCourseModel.Interfaces;

namespace LibraryManagementCourse.Data.Interfaces
{
    public interface IAuthorRepository : IRepository<Author>
    {
        IEnumerable<Author> GetAllWithBooks();
        Author GetWithBooks(int id);
    }
}
