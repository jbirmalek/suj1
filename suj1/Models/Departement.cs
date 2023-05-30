using System.ComponentModel.DataAnnotations;

namespace suj1.Models
{
    public class Departement
    {
        public int DepartementId { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Nom { get; set; }
        [Required]
        public float Responsable { get; set; }

        public ICollection<Enseignant> Enseignants { get; set; }


    }
}
