using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Data
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int IdCategory { get; set; }

        [Required]
        public string NameCategory { get; set; }

        public virtual ICollection<Goods> Goods { get; set;}
    }
}
