using System;
using LibraryManagementCourse.Data.Interfaces;
using LibraryManagementCourse.Data.Model;
namespace LibraryManagementCourse.Data.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(LibraryDbContext context) : base(context)
        {
        }
    }
}
