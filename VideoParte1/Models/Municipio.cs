using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/*USING ADICIONALES*/
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoParte1.Models
{
    [Table("municipio")]
    public class Municipio
    {

        [Key]
        public int Id { get; set; }

        [Required (ErrorMessage = "Ingrese el nombre del municipio")]        
        [StringLength(20, MinimumLength = 4)]
        [Display(Name = "Nombre del municipio")]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }





        //DEFINICION DE FORANEA 1 A N
        [Display(Name = "Seleccione un departamento")]
        public int IdDepartamento { get; set; }
        [ForeignKey("IdDepartamento")]
        public Departamento departamento { get; set; }





        /*RELACION DE N A N */
        public virtual ICollection<Empresa> Empresas { get; set; }



    }
}