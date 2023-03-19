using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class CategoryModel
    {
        [Required]
        public string NameCategory { get; set; }
    }
}
