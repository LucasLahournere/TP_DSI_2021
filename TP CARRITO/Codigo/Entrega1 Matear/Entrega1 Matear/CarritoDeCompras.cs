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
            bool bandera = false;

            ItemProducto prod = new ItemProducto();
            prod.Producto = producto;
            prod.CantidadProductosSeleccionados = cantidad;

            ItemProducto Aux = new ItemProducto();

            foreach (ItemProducto p in ProductoSeleccionados)
            {
                if (p.Producto.Id == prod.Producto.Id)
                {
                    bandera = true;
                    Aux = p;
                }

            }

            if (bandera == true)
            {
                Aux.CantidadProductosSeleccionados = Aux.CantidadProductosSeleccionados + cantidad;

            }
            else
            {
                productoSeleccionados.Add(prod);
            }

        }

        public bool eliminarProductos(ItemProducto producto,int cantidad)
        {
            bool ban = false;
            foreach (ItemProducto i in productoSeleccionados)
            {
                if (i == producto)
                {
                    if (i.CantidadProductosSeleccionados != 0) // modifico solo la cantidad de productos
                    {
                        i.CantidadProductosSeleccionados = i.CantidadProductosSeleccionados - cantidad;
                    }
                    else // si la cantidad igual a 0, envio una bandera para eliminar el objeto de la lista
                    { 
                        ban = true;
                    }

                }

            }

            return ban;
        }

    }
}
