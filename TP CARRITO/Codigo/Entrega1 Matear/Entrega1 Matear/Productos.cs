using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega1_Matear
{
    class Productos
    {
        int id;
        float precioUnitario;
        int stockDisponible;
        string descripcion;
        int cantidadDeProductos;
        //List<ItemProducto> cantidadDeProductos ;

        public float PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public int StockDisponible { get => stockDisponible; set => stockDisponible = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
       // internal List<ItemProducto> CantidadDeProductos { get => cantidadDeProductos; set => cantidadDeProductos = value; }
        public int Id { get => id; set => id = value; }
        public int CantidadDeProductos { get => cantidadDeProductos; set => cantidadDeProductos = value; }

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
