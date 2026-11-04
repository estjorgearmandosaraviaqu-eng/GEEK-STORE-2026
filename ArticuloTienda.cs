using System;
using System.Collections.Generic;
using System.Text;

namespace GEEK_STORE_2026
{
    public abstract class ArticuloTienda
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double PrecioCosto { get; set; }
        public double PrecioVenta { get; set; }
        public int Stock { get; set; }
        public ArticuloTienda(int id, string nombre, double precioCosto, double precioVenta, int stock)
        {
            Id = id;
            Nombre = nombre;
            PrecioCosto = precioCosto;
            PrecioVenta = precioVenta;
            Stock = stock;
        }
        public abstract void MostrarDetalles();
    }
}