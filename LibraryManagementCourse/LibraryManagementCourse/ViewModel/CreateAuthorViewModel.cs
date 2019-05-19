using System.ComponentModel.DataAnnotations;
using LibraryManagementCourse.Data.Model;

namespace LibraryManagementCourse.ViewModel
{
    public class CreateAuthorViewModel
    {
        [Required]
        public Author Author { get; set; }
        public string Referer { get; set; }
    }

}