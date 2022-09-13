using System.ComponentModel.DataAnnotations;

namespace MenaxhimBibliotekeMvcApp.Models
{
    public class Author
    {

        [Key]
        public int Id { get; set; }

        [Display(Name= "Name")]
        public string Name { get; set; }


        [Display(Name="Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Motherland")]
        public string MotherLand { get; set; }

        [Display(Name="Birthday")]
        public DateTime Birthday { get; set; }

        public List<Author_Book> Author_Books { get; set; }

    }
}
