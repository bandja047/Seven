using MotherStoreApi.Models;

namespace MotherStoreApi.DataTransfertObject
{
    public class CategorieCreateDao
    {      
        public string Name { get; set; }      
        public int? ParentCategorieId { get; set; }

        public string? Description { get; private set; }
       
    }
}
