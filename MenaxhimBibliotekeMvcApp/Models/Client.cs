using System.ComponentModel.DataAnnotations;

namespace MenaxhimBibliotekeMvcApp.Models
{
    public class Client
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public Contract Contracts { get; set; }

    }
}
