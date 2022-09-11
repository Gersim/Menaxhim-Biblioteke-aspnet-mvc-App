using System.ComponentModel.DataAnnotations;

namespace MenaxhimBibliotekeMvcApp.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        //Relationships
        public List<Contract> Contracts { get; set; }

    }
}
