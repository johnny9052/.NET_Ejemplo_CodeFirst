using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*Using adicional para que funcione las anotaciones*/
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VideoParte1.Models
{
    [Table("producto")]
    public class Producto
    {
        [Key] //Establece PK
        public int Id { get; set; }        
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
    }
}