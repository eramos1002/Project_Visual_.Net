using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MySecondProject.Models
{
    [Table("Producto")]
    public class Producto
    {
        [Column("Id")]
        [Display(Name ="Codigo")]

        public int Id { get; set; }

        [Column("Nombre")]
        [Display(Name = "Nom")]
        public string? Nombre { get;  set; }

        [Column("Precio")]
        [Display(Name = "Price")]
        public int Precio { get; set; }



    }
}
