using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega1_Matear
{
    class CarritoDeCompras
    {
        int numeroPedido;
        float montoTotal;
        DateTime fechaCompra;
        List<ItemProducto> productoSeleccionados = new List<ItemProducto>(); //listado de los productos seleccionados
        Descuento codigoDescuento; 

        public int NumeroPedido { get => numeroPedido; set => numeroPedido = value; }
        public float MontoTotal { get => montoTotal; set => montoTotal = value; }
        public DateTime FechaCompra { get => fechaCompra; set => fechaCompra = value; }
        public Descuento CodigoDescuento { get => codigoDescuento; set => codigoDescuento = value; }
        internal List<ItemProducto> ProductoSeleccionados { get => productoSeleccionados; set => productoSeleccionados = value; }

        public void mostrarCarrito()
        {

            Console.WriteLine("------------------------CARRITO-----------------------------------------------");
            Console.WriteLine("El numero del carrito es: #" + numeroPedido);
            Console.WriteLine("La fecha de compra es: "+fechaCompra);
            Console.WriteLine("Los productos son: ");

            foreach (ItemProducto prod in productoSeleccionados)
            {
                Console.WriteLine(prod.Producto.Descripcion);
                Console.WriteLine("ID: "+ prod.Producto.Id);
                Console.WriteLine("Cantidad: " + prod.CantidadProductosSeleccionados);
            }

            Console.WriteLine("TOTAL: " + montoTotal);

            Console.WriteLine("-----------------------------------------------------------------------------");

        }


        public void agregarProductos(ItemProducto producto)
        {
            foreach (ItemProducto p in productoSeleccionados)
            {
                if (p.Producto.Id == producto.Producto.Id)
                {
                    producto.Producto.CantidadDeProductos = p.Producto.CantidadDeProductos + producto.Producto.CantidadDeProductos;
                }

            }

            productoSeleccionados.Add(producto);

        }

        public void eliminarProductos(ItemProducto producto)
        {
            ProductoSeleccionados.Remove(producto);
        }



    }
}
