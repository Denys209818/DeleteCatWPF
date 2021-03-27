using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataContextEntities
{
    [Table("tblAppCatsHW3")]
    public class AppCat
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Name { get; set; }
        [Required]
        public string ImgUrl { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
    }
}
