using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagementCourse.Data.Model
{
    public class Customer
    {

        //Здесь хранятся id и имя клиента
        public int CustomerId { get; set; }
        [Required, MinLength(3), MaxLength(50)]
        public string Name { get; set; }

        public Customer()
        {
        }
    }
}
