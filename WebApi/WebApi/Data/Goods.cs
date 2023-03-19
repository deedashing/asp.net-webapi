using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Data
{
    [Table("Good")]
    public class Goods
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public string Description { get; set; }

        [Range(0, double.MaxValue)]
        public string Price { get; set; }

        public byte Disscount { get; set; }


        public int ?IdCategory { get; set; }
        [ForeignKey("IdCategory")]
        public Category Category { get; set; }
    }
}
