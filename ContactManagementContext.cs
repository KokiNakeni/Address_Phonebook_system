using Microsoft.EntityFrameworkCore;

namespace ContactsAddressManagement.Models
{
    public class ContactManagementContext : DbContext
    {
        public ContactManagementContext(DbContextOptions<ContactManagementContext> options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get ;set; }
        public DbSet<ContactAddress> ContactAddresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().ToTable("Contact");
            modelBuilder.Entity<ContactAddress>().ToTable("ContactAddress");
        }
    }
}
