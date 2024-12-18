namespace MotherStoreApi.DataTransfertObject
{
    public class ArticleUpdateDto
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public string Designation { get; set; }
        public string Description { get; set; }
        public double Quantite { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateMaj { get; set; }
        public double PrixAchat { get; set; }
        public double PrixVente { get; set; }
        public string UniteVente { get; set; }
        public int DataVersion { get; set; }
        public int CategorieId { get;  set; }
    }
}
