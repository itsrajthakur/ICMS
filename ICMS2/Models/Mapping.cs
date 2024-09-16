using System.ComponentModel.DataAnnotations;

namespace ICMS2.Models
{
    public class Mapping
    {
        [Key]
        public int Id { get; set; }
        public string ProductId { get; set; }
        public int UserPrice { get; set; }
        public string UserItemCode { get; set; }
    }
}
