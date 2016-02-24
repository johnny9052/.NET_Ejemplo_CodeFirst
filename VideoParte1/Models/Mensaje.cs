using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VideoParte1.Models
{

    [Table("mensaje")]
    public class Mensaje
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese el contenido del mensaje")]
        [StringLength(2000, MinimumLength = 1)]
        [Display(Name = "Contenido del mensaje")]
        public string contenido { get; set; }
    }
}