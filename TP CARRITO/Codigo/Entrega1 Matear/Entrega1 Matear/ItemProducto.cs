using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega1_Matear
{
    public class ItemProducto
    {
        int cantidadProductosSeleccionados;
        Productos producto;
        CarritoDeCompras carrito;


        public int CantidadProductosSeleccionados { get => cantidadProductosSeleccionados; set => cantidadProductosSeleccionados = value; }
        public Productos Producto { get => producto; set => producto = value; }
        public CarritoDeCompras Carrito { get => carrito; set => carrito = value; }


    }
}
