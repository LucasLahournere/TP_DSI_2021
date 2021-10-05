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

            foreach (ItemProducto prod in ProductoSeleccionados)
            {
                Console.WriteLine(prod.Producto.Descripcion);
                Console.WriteLine("ID: "+ prod.Producto.Id);
                Console.WriteLine("Cantidad: " + prod.CantidadProductosSeleccionados);
            }

            Console.WriteLine("TOTAL: $" + montoTotal);

            Console.WriteLine("-----------------------------------------------------------------------------");

        }

        public void agregarProductos(Productos producto, int cantidad)
        {

            ItemProducto prod = new ItemProducto();
            prod.Producto = producto;
            prod.CantidadProductosSeleccionados = prod.CantidadProductosSeleccionados + cantidad;

            productoSeleccionados.Add(prod);

        }

        public int eliminarProductos(Productos producto,int cantidad)
        {

            ItemProducto product = new ItemProducto();
            product.Producto = producto;
            product.CantidadProductosSeleccionados = cantidad ;

            int contador = -1;
            int indice = 0;
            int ban1 = 0;

            foreach (ItemProducto p in ProductoSeleccionados)
            {
                contador++;
                if (p.Producto.Id == product.Producto.Id && p.CantidadProductosSeleccionados >= product.CantidadProductosSeleccionados)
                {
                    indice = contador;
                    ban1 = 1;

                }
                else if (p.Producto.Id == product.Producto.Id && p.CantidadProductosSeleccionados < product.CantidadProductosSeleccionados)
                {
                    Console.WriteLine("Solo selecciono " + p.CantidadProductosSeleccionados + " cantidad del producto, si quiere eliminar vuelva a intentarlo");
                }
            }

            if (ban1 == 1)
            {
                ProductoSeleccionados.RemoveAt(indice);
            }

            return ban1;
        }

    }
}
