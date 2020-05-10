using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestionInventario.Models
{
    public partial class Producto
    {
        public long IdProducto { get; set; }
        [Required(ErrorMessage = "El campo de nombre es requerido")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo de categoría es requerido")]
        [DisplayName("Categoría")]
        public long? IdCategoria { get; set; }
        public string Color { get; set; }
        [Required(ErrorMessage = "El campo de precio unitario es requerido")]
        [DisplayName("Precio unitario")]
        public decimal PrecioUnitario { get; set; }
        [Required(ErrorMessage = "El campo de cantidad disponible es requerido")]
        [DisplayName("Cantidad disponible")]
        public long CantidadDisponible { get; set; }
        [DisplayName("Fecha de creación")]
        public DateTime FechaCreacion { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
    }
}
