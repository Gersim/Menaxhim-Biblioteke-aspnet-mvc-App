using MenaxhimBibliotekeMvcApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MenaxhimBibliotekeMvcApp.Data
{
    public class AppDbContex:DbContext
    {
        public AppDbContex(DbContextOptions<AppDbContex>options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author_Book>().HasKey(ab => new
            {
                ab.AuthorId,
                ab.BookId
            });
            modelBuilder.Entity<Author_Book>().HasOne(b => b.Book).WithMany(ab => ab.Author_Books).HasForeignKey(ab => ab.BookId);
            modelBuilder.Entity<Author_Book>().HasOne(a => a.Author).WithMany(ab => ab.Author_Books).HasForeignKey(ab => ab.AuthorId);
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Author> Authors { get;set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author_Book> Author_Book { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Contract> Contracts { get; set; }
    }
}
