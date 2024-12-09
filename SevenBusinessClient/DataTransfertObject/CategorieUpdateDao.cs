using SevenApi.Models;

namespace SevenApi.DataTransfertObject
{
    public class CategorieUpdateDao
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public string Name { get; set; }
        public int DataVersion { get; set; }
        public int? ParentCategorieId { get; set; }
        
       
    }
}
