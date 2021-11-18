using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Entrega1_Matear
{
    public class CarritoDeCompras
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
                Console.WriteLine("ID: " + prod.Producto.Id);
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
                if (i.Producto.Id == producto.Producto.Id)
                {
                    i.CantidadProductosSeleccionados = i.CantidadProductosSeleccionados - cantidad;

                    if (i.CantidadProductosSeleccionados <= 0) 
                    { 
                        ban = true;
                    }

                }

            }
            
            return (ban);
        }
        
        public void calcularImporteTotal()
        {
            montoTotal = 0;
            float precio = 0;

            foreach(ItemProducto p in ProductoSeleccionados)
            {

                if (p.Producto.EstaEnOferta == true && DateTime.Compare(p.Producto.FechaInicioOferta, DateTime.Now) < 0  && DateTime.Compare(p.Producto.FechaFinOferta, DateTime.Now) > 0)
                {
                    precio = (p.Producto.PrecioUnitario - (p.Producto.PrecioUnitario * p.Producto.PrecioOferta));
                }
                else 
                {
                    precio = p.Producto.PrecioUnitario;
                }



                if (p.CantidadProductosSeleccionados >= 2 && p.CantidadProductosSeleccionados <= 5)
                {
                    precio = precio - (precio * p.Producto.PorcDescuentoEntreDosYCinco);

                }
                else if (p.CantidadProductosSeleccionados >= 6 && p.CantidadProductosSeleccionados <= 10)
                {
                    precio = precio - (precio * p.Producto.PorcDescuentoEntreSeisYDiez);

                }
                else if (p.CantidadProductosSeleccionados > 10)
                {
                    precio = precio - (precio * p.Producto.PorcDescuentoMasDeDiez);
                }


                MontoTotal = (precio  * p.CantidadProductosSeleccionados) + MontoTotal;

            }

        }

        public void aplicarDescuento(Descuento descuento)
        {
            MontoTotal = MontoTotal - (MontoTotal * descuento.PorcentajeDto);
        }

        public void generarJson()
        {
            CarritoDeComprasDTO carritoDTO = new CarritoDeComprasDTO();
            carritoDTO.FechaCompra = Convert.ToString(FechaCompra);
            carritoDTO.MontoTotal = MontoTotal;
            TextWriter CarroSerializado = new StreamWriter("carrito.txt");
            CarroSerializado.WriteLine(System.Text.Json.JsonSerializer.Serialize(carritoDTO));
            CarroSerializado.Close();
        }

        
    }
}
