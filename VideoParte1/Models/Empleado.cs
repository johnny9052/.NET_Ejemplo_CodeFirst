using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/*Using necesarios*/
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoParte1.Models
{
    [Table("empleado")]
    public class Empleado
    {

        [Key]
        public int Id { get; set; }       
 
        [Required(ErrorMessage = "En nombre del empleado es obligatorio")]
        [StringLength(10,MinimumLength=4)]
        
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Ingrese la direccion")]
        [StringLength(50)]
        public string Direccion { get; set; }


        [Required(ErrorMessage = "Ingrese el salario")]
        [Range(3000,1000000,ErrorMessage="Debe estar entre 3000 y 1000000")]
        public decimal salario { get; set; }

        //[DataType(DataType.EmailAddress)]        
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}",
            ErrorMessage="Ingrese el correo de manera correcta")]
        public string correo { get; set; }        
    }
}