using System.ComponentModel.DataAnnotations;

namespace AppApi.Models
{
    public class Category:BaseEntity
    {
        [StringLength(255)]
        public string? Name { get; set; }
    }
}
