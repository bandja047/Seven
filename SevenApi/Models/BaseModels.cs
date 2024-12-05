using System.ComponentModel.DataAnnotations.Schema;

namespace Seven.Models
{
    public class BaseModels
    {
        
        public  DateTime CreatedAt { get; set; }
       
        public DateTime UpdatedAt { get; set; }
        public int DataVersion { get; set; }
    }
}
