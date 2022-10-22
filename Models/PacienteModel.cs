using System.ComponentModel.DataAnnotations;

namespace Checkpoint03_Enterprise.Models
{
    public class PacienteModel
    {

        public int Id { get; set; }
        
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        //Adress
        public string StreetName { get; set; }

        public int StreetNumber { get; set; }

        public string Neighborhood { get; set; }

        public string City { get; set; }

        public string Country { get; set; }
    }
}
