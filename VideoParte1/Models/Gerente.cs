using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*Using adicional para que funcione las anotaciones*/
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace VideoParte1.Models
{
    [Table("gerente")]
    public class Gerente
    {

        [Key, ForeignKey("Empresa")] //Establece PK
        public int idEmpresa { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public decimal Salario { get; set; }

        

        /*RELACION DE 1 A 1 */
        public virtual Empresa Empresa { get; set; }

    }
}