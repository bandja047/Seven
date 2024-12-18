using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MotherStoreApi.Models
{
    public class Categorie : BaseModels
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
       
        [Required]
        public  string Reference { get; set; }       
      
        [Required]
        public string Name { get; set; }
        
        public int? ParentCategorieId { get; set; }

        [JsonIgnore]
       // public Categorie ParentCategorie { get; set; }
        //public List<Categorie> SousCategories { get; set; }
        public List<Article> Articles { get; set; }
    }
}
