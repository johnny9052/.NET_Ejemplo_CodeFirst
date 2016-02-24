using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*Using necesarios*/
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace VideoParte1.Models
{
    [Table("departamento")]
    public class Departamento
    {

        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage = "Ingrese el nombre del departamento")]        
        [StringLength(20, MinimumLength = 4)]
        [Display(Name = "Nombre del departamento")]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }


        //DEFINICION DE FORANEA 1 A N
        public ICollection<Municipio> municipio { get; set; }

    }
}