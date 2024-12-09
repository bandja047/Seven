using SevenApi.Models;

namespace SevenApi.DataTransfertObject
{
    public class CategorieCreateDao
    {      
        public string Name { get; set; }      
        public int? ParentCategorieId { get; set; }
       
    }
}
