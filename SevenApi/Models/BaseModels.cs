using System.ComponentModel.DataAnnotations.Schema;

namespace MotherStoreApi.Models
{
    public class BaseModels
    {
        
        public  DateTime CreatedAt { get; set; }
       
        public DateTime UpdatedAt { get; set; }
        public int DataVersion { get; set; }
    }
}
