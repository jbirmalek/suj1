using System.ComponentModel.DataAnnotations;

namespace suj1.Models
{
    public class Enseignant
    {
        public int EnseignantId { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Nom { get; set; }
        [Required]
       
        public float Prenom { get; set; }
        [Required]
       
        public int Quantite { get; set; }
        [Required]

        public int DateNaissance { get; set; }
        [Required]

        public int Grade { get; set; }
         
        public int DepartementId { get; set; }

        public Departement Departement { get; set; }

    }
}
