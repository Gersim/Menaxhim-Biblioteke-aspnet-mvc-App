using System.ComponentModel.DataAnnotations;

namespace MenaxhimBibliotekeMvcApp.Models
{
    public class Contract
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public string Book { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndTime { get; set; }

        //Relationships
        public List<Client> Clients { get; set; }
        public List<Book> Books { get; set; }
    }
}
