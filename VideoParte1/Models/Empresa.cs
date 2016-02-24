using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*USING ADICIONALES*/
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoParte1.Models
{
    [Table("empresa")]
    public class Empresa
    {

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Ingrese el nombre de la empresa")]
        [StringLength(20, MinimumLength = 4)]

        [Display(Name = "Nombre de la empresa")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Ingrese la mision y vision de la empresa")]
        public string MisionVision { get; set; }


        /*RELACION DE N A N */
        public virtual ICollection<Municipio> Municipios { get; set; }


        /*RELACION DE 1 A 1 */
        public virtual Gerente Gerente { get; set; }

    }
}