using MotherStoreBusiness.Models;

namespace MotherStoreBusiness.DataTransfertObject
{
    public class ArticleCreateDto
    {
        public string Designation { get; set; }
        public string Description { get; set; }
        public double Quantite { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateMaj { get; set; }
        public double PrixAchat { get; set; }
        public double PrixVente { get; set; }
        public string UniteVente { get; set; }
        public CategorieUpdateDto Categorie { get;  set; }


    }
}
