using MotherStoreBusiness.Models;

namespace MotherStoreBusiness.DataTransfertObject
{
    public class CategorieUpdateDto
    {
        public int Id { get; set; }
        public string Reference { get; set; }
        public string Name { get; set; }
        public int DataVersion { get; set; }
        public int? ParentCategorieId { get; set; }
        
       
    }
}
