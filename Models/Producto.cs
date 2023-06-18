using System;
using System.Collections.Generic;

namespace DeberScaffod.Models
{
    public partial class Producto
    {
        public Producto()
        {
            DetallesFacturas = new HashSet<DetallesFactura>();
        }

        public int IdProducto { get; set; }
        public string? Nombre { get; set; }
        public decimal? Precio { get; set; }
        public int? Stock { get; set; }

        public virtual ICollection<DetallesFactura> DetallesFacturas { get; set; }
    }
}
