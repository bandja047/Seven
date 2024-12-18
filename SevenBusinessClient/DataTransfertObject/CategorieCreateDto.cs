using MotherStoreBusiness.Models;

namespace MotherStoreBusiness.DataTransfertObject
{
    public class CategorieCreateDto
    {
        public string Name { get; set; }
        public int? ParentCategorieId { get; set; }

        public string? Description { get; private set; }

    }
}
