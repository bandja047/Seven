namespace MotherStoreBO.DataTransfertObject
{
    public class ClientCreateDto
    {
      
        public string Name { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string Pays { get; set; }
        public string Ville { get; set; }
        public string Quartier { get; set; }
        public string CodePostale { get; set; }
        public string? Type { get; set; }
        public int? ProgrammeFidelite { get; set; }
        public float? LimiteDeCredit { get; set; }
    }
}
