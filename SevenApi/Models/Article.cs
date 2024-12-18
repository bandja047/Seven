using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MotherStoreApi.Models
{
    public class Article : BaseModels
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Reference { get; set; }
        [Required]
        public string Designation { get; set; }       
        public string Description { get; set; }
        public double Quantite { get; set; }
        public double PrixAchat { get; set; }
        public double PrixVente { get; set; }
        public string UniteVente { get; set; }
        public int CategorieId { get; set; }
        public Categorie Categories { get; set; }


    }
}
