using System.ComponentModel.DataAnnotations;

namespace ICMS2.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
