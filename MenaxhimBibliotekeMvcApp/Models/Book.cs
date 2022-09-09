using MenaxhimBibliotekeMvcApp.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MenaxhimBibliotekeMvcApp.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string CoverImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public BookZhanra BookZhanra { get; set; }
        public int BookNumbers { get; set; }
        public string BookLocation { get; set; }

        //Relationships
        public List<Author_Book> Author_Books { get; set; }
        public List<Contract> Contracts { get; set; }
    }
}
