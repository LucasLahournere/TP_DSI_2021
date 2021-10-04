using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega1_Matear
{
    class ItemProducto
    {
        int cantidadProductosSeleccionados;
        Productos producto;
        CarritoDeCompras carrito;


        public int CantidadProductosSeleccionados { get => cantidadProductosSeleccionados; set => cantidadProductosSeleccionados = value; }
        internal Productos Producto { get => producto; set => producto = value; }
        internal CarritoDeCompras Carrito { get => carrito; set => carrito = value; }


    }
}
