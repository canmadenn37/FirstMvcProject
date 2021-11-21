using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMvcProject.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("Name",TypeName ="varchar")]
        [StringLength(50)]
        public string Name { get; set; }

        public int DisplayOrder { get; set; }
    }
}
