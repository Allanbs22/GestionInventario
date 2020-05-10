using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GestionInventario.Models
{
    public partial class Categoria
    {
        public Categoria()
        {
            Producto = new HashSet<Producto>();
        }

        public long IdCategoria { get; set; }
        [Required(ErrorMessage = "El campo de nombre es requerido")]
        public string Nombre { get; set; }
        [DisplayName("Fecha de creación")]
        public DateTime FechaCreacion { get; set; }

        public virtual ICollection<Producto> Producto { get; set; }
    }
}
