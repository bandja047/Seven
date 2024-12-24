using MotherStoreBO.Models;

namespace MotherStoreBO.DataTransfertObject
{
    public class CategorieUpdateDto
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public string Name { get; set; }
        public int DataVersion { get; set; }
        public string Description { get; set; }
        public int? ParentCategorieId { get; set; }
        
       
    }
}
