using System;

using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Entrega1_Matear
{


    class Program
    {
        static void Main(string[] args)
        {

            //listas
            List<Productos> ListaProductos = new List<Productos>();
            List<ItemProducto> ListaItemProductos = new List<ItemProducto>();
            List<Descuento> Descuentos = new List<Descuento>();

            //agrego carrito
            CarritoDeCompras carrito1 = new CarritoDeCompras();
            carrito1.NumeroPedido = 1;
            carrito1.FechaCompra = DateTime.Now;

            // agrego productos
            Productos prod1 = new Productos();
            prod1.Id = 1;
            prod1.PrecioUnitario = 22.5f;
            prod1.StockDisponible = 1;
            prod1.Descripcion = "Mate de madera";
            ListaProductos.Add(prod1); 

            Productos prod2 = new Productos();
            prod2.Id = 2;
            prod2.PrecioUnitario = 60f;
            prod2.StockDisponible = 20;
            prod2.Descripcion = "Mate de vidrio";
            ListaProductos.Add(prod2);

            //agrego descuentos
            Descuento dto1 = new Descuento();
            dto1.CodigoDto = "MatesDSI";
            dto1.PorcentajeDto = 0.30f;
            Descuentos.Add(dto1);


            ItemProducto producto1 = new ItemProducto();
            producto1.Producto = prod1;
            ListaItemProductos.Add(producto1);

            ItemProducto producto2 = new ItemProducto();
            producto2.Producto = prod2;
            ListaItemProductos.Add(producto2);

            Console.WriteLine("CARRITO DE COMPRAS");

            int ban = 0;

            while (ban == 0)
            {
                Console.WriteLine("Ingrese la opcion: " );
                Console.WriteLine("1) Agregar un producto al carrito." );
                Console.WriteLine("2) Eliminar un producto del carrito." );
                Console.WriteLine("3) Aplicar un codigo de dcto" );
                Console.WriteLine("4) Mostrar carrito." );
                Console.WriteLine("5) Confirmar compra");

                int op = int.Parse(Console.ReadLine());
                
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Los siguientes productos se encuentran disponibles: ");

                        foreach (Productos prod in ListaProductos)
                        {
                            if (prod.StockDisponible >= 1)
                            {
                                prod.mostrarProductos();
                            }
                        }

                        Console.WriteLine("Seleccione el ID del producto que desea agregar al carrito");
                        int productoelegido = int.Parse(Console.ReadLine());

                        Console.WriteLine("¿Cuanta cantidad desea agregar?");
                        int cantidad = int.Parse(Console.ReadLine());


                        foreach (ItemProducto p in ListaItemProductos)
                        {
                            if (productoelegido == p.Producto.Id && cantidad <= p.Producto.StockDisponible)
                            {

                                p.CantidadProductosSeleccionados = cantidad;
                                carrito1.agregarProductos(p);
                                carrito1.MontoTotal = (p.Producto.PrecioUnitario * cantidad) + carrito1.MontoTotal;
                                p.Producto.StockDisponible = p.Producto.StockDisponible - cantidad;

                                Console.WriteLine("PRODUCTOS AGREGADOS CORRECTAMENTE");
                            }
                            else 
                            if (productoelegido == p.Producto.Id && cantidad > p.Producto.StockDisponible)
                            {
                                
                                Console.WriteLine("No hay stock suficiente. Intente nuevamente");
                            } 

                        }

                        break;

                    case 2:

                        carrito1.mostrarCarrito();
                        Console.WriteLine("¿Que productos desea eliminar?(seleccione el ID)");
                        int prodeliminar = int.Parse(Console.ReadLine());

                        Console.WriteLine("¿Cuanta cantidad desea eliminar?");
                        int cantidadEliminar = int.Parse(Console.ReadLine());

                        foreach (ItemProducto p in ListaItemProductos)
                        {
                            if (prodeliminar == p.Producto.Id && cantidadEliminar <= p.CantidadProductosSeleccionados)
                            {
                                carrito1.eliminarProductos(p);
                                carrito1.MontoTotal = carrito1.MontoTotal - (p.Producto.PrecioUnitario * cantidadEliminar);
                                p.Producto.StockDisponible = p.Producto.StockDisponible + cantidadEliminar;

                                Console.WriteLine("PRODUCTOS ELIMINADOS CORRECTAMENTE");
                            }
                            if (prodeliminar == p.Producto.Id && cantidadEliminar > p.CantidadProductosSeleccionados)
                            {
                                Console.WriteLine("Solo selecciono " + p.CantidadProductosSeleccionados + " cantidad del producto, si quiere eliminar vuelva a intentarlo");
                            }

                        }

                        break;

                    case 3:
                        Console.WriteLine("Ingrese el codigo de descuento: ");
                        string codigosDTO = Console.ReadLine();

                        foreach (Descuento desc in Descuentos)
                        {
                            if (codigosDTO == desc.CodigoDto)
                            {
                                carrito1.MontoTotal = carrito1.MontoTotal - (carrito1.MontoTotal * desc.PorcentajeDto) ;
                                carrito1.mostrarCarrito();
                                Console.WriteLine("DESCUENTO APLICADO CORRECTAMENTE!");

                            }else if (codigosDTO != desc.CodigoDto)
                            {
                                Console.WriteLine("NO SE ENCONTRO EL CODIGO, INTENTE NUEVAMENTE");
                            }
                        }

                        break;
                    case 4:
                        carrito1.mostrarCarrito();
                        break;

                    case 5:
                        Console.WriteLine("-------------------GRACIAS POR SU COMPRA-------------------------------");
                        Console.WriteLine("Redirigiendo a cobros ");

                        CarritoDeComprasDTO carritoDTO = new CarritoDeComprasDTO();
                        carritoDTO.FechaCompra = Convert.ToString(carrito1.FechaCompra);
                        carritoDTO.MontoTotal = carrito1.MontoTotal;
                        TextWriter CarroSerializado = new StreamWriter("carrito.txt");
                        CarroSerializado.WriteLine(JsonSerializer.Serialize(carritoDTO));
                        CarroSerializado.Close();

                        ban = 1;
                        break;

                }

            }

        }

    }

}


