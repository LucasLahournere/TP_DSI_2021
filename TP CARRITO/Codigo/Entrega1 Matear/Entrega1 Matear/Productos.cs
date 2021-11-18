using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega1_Matear
{
    public class Productos
    {
        int id;
        float precioUnitario;
        int stockDisponible;
        string descripcion;

        bool estaEnOferta;
        float porcDescuentoEntreDosYCinco;
        float porcDescuentoEntreSeisYDiez;
        float porcDescuentoMasDeDiez;
        float precioOferta;
        DateTime fechaInicioOferta;
        DateTime fechaFinOferta;

        List<ItemProducto> cantidadDeProductos ;

        public float PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public int StockDisponible { get => stockDisponible; set => stockDisponible = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        internal List<ItemProducto> CantidadDeProductos { get => cantidadDeProductos; set => cantidadDeProductos = value; }
        public int Id { get => id; set => id = value; }
        public bool EstaEnOferta { get => estaEnOferta; set => estaEnOferta = value; }
        public float PorcDescuentoEntreDosYCinco { get => porcDescuentoEntreDosYCinco; set => porcDescuentoEntreDosYCinco = value; }
        public float PorcDescuentoEntreSeisYDiez { get => porcDescuentoEntreSeisYDiez; set => porcDescuentoEntreSeisYDiez = value; }
        public float PorcDescuentoMasDeDiez { get => porcDescuentoMasDeDiez; set => porcDescuentoMasDeDiez = value; }
        public float PrecioOferta { get => precioOferta; set => precioOferta = value; }
        public DateTime FechaInicioOferta { get => fechaInicioOferta; set => fechaInicioOferta = value; }
        public DateTime FechaFinOferta { get => fechaFinOferta; set => fechaFinOferta = value; }

        public void mostrarProductos()
        {

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Precio Unitarios: " + precioUnitario);
            Console.WriteLine("Stock: " + stockDisponible);
            Console.WriteLine("Descripcion: " + descripcion);
            Console.WriteLine("-------------------------------------------");

        }


        
    }

}
