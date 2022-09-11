using System.ComponentModel.DataAnnotations;

namespace MenaxhimBibliotekeMvcApp.Models
{
    public class Contract
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndTime { get; set; }

        //Relationships
        public int ClientId { get; set; }
        public Client Clients { get; set; }

        public int BookId { get; set; }
        public Book Books { get; set; }
    }
}
