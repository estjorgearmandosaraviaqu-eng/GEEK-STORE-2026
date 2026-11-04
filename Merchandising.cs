using System;
using System.Collections.Generic;
using System.Text;

namespace GEEK_STORE_2026
{
    public class Merchandising : ArticuloTienda, IComercializable
    {
        public string Tipo { get; set; }
        public string Talla { get; set; }

        public Merchandising(int id, string nombre, double precioCosto, double precioVenta, int stock, string tipo, string talla)
            : base(id, nombre, precioCosto, precioVenta, stock)
        {
            Tipo = tipo;
            Talla = talla;
        }
        double IComercializable.CalculartotalVenta(int cantidadComprada)
        {
            return PrecioVenta * cantidadComprada;
        }
        public override void MostrarDetalles()
        {
            if (Stock > 0)
            {
                Console.WriteLine($"ID: {Id}");
                Console.WriteLine($"Nombre: {Nombre}");
                Console.WriteLine($"Precio de Costo: {PrecioCosto}");
                Console.WriteLine($"Precio de Venta: {PrecioVenta}");
                Console.WriteLine($"Stock: {Stock}");
                Console.WriteLine($"Tipo: {Tipo}");
                Console.WriteLine($"Talla: {Talla}");
            }
        }
    }
}