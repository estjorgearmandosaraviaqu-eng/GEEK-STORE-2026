using System;
using System.Collections.Generic;
using System.Text;

namespace GEEK_STORE_2026
{
    public class Comic : ArticuloTienda, IComercializable
    {
        public int Volumen { get; set; }
        public bool EsVariante { get; set; }
        public Comic(int id, string nombre, double precioCosto, double precioVenta, int stock, int volumen, bool esVariante)
            : base(id, nombre, precioCosto, precioVenta, stock)
        {
            Volumen = volumen;
            EsVariante = esVariante;
        }
        double IComercializable.CalculartotalVenta(int cantidadComprada)
        {
            if (EsVariante == true)
            {
                return PrecioVenta * cantidadComprada * 1.2;
            }
            return PrecioVenta * cantidadComprada;
        }
        public override void MostrarDetalles()
        {
            if (Stock > 0) //si hay stock, muestra los detalles
            {
                Console.WriteLine($"ID: {Id}");
                Console.WriteLine($"Nombre: {Nombre}");
                Console.WriteLine($"Precio de Costo: {PrecioCosto}");
                Console.WriteLine($"Precio de Venta: {PrecioVenta}");
                Console.WriteLine($"Stock: {Stock}");
                Console.WriteLine($"Volumen: {Volumen}");
                Console.WriteLine($"Es Variante: {EsVariante}");
            }

        }
    }
}
