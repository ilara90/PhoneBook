using Microsoft.EntityFrameworkCore;

namespace PhoneBook.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Person> Persons { get; set; } = null!;

        public ApplicationContext(DbContextOptions options)
        : base(options)
        {
        }
    }

}
