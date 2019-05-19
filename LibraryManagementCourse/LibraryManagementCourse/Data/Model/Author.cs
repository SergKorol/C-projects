using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementCourse.Data.Model
{
    public class Author
    {
        //id автора и его имя
        public int AuthorId { get; set; }
        [Required, MinLength(3), MaxLength(50)]
        public string Name { get; set; }
        //Коллекция книг, которая будет закрепляться за автором книги
        public virtual ICollection<Book> Books { get; set; }
    }
}
