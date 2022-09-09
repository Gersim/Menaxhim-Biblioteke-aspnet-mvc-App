using System.ComponentModel.DataAnnotations;

namespace MenaxhimBibliotekeMvcApp.Models
{
    public class Author
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string MotherLand { get; set; }
        public DateTime Birthday { get; set; }

        public List<Author_Book> Author_Books { get; set; }

    }
}
