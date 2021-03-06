using Newtonsoft.Json;
using System;

using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Entrega1_Matear
{
    public class Program
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
            prod1.EstaEnOferta = false;
            prod1.PrecioOferta = 0.05f;
            prod1.FechaInicioOferta = DateTime.Parse("6/11/2021 20:00:00 ") ;
            prod1.FechaFinOferta = DateTime.Parse("31/12/2021 20:00:00 ") ;
            prod1.PorcDescuentoEntreDosYCinco = 0.05f;
            prod1.PorcDescuentoEntreSeisYDiez = 0.10f;
            prod1.PorcDescuentoMasDeDiez = 0.13f;

            ListaProductos.Add(prod1); 

            Productos prod2 = new Productos();
            prod2.Id = 2;
            prod2.PrecioUnitario = 60f;
            prod2.StockDisponible = 20;
            prod2.Descripcion = "Mate de vidrio";
            prod2.EstaEnOferta = true;
            prod2.PrecioOferta = 0.05f;
            prod2.FechaInicioOferta = DateTime.Parse("6/11/2021 20:00:00 ");
            prod2.FechaFinOferta = DateTime.Parse("31/12/2021 20:00:00 ");
            prod2.PorcDescuentoEntreDosYCinco = 0.05f;
            prod2.PorcDescuentoEntreSeisYDiez = 0.10f;
            prod2.PorcDescuentoMasDeDiez = 0.13f;
            ListaProductos.Add(prod2);

            Productos prod3 = new Productos();
            prod3.Id = 3;
            prod3.PrecioUnitario = 9f;
            prod3.StockDisponible = 60;
            prod3.Descripcion = "Bombilla";
            prod3.EstaEnOferta = true;
            prod3.PrecioOferta = 0.05f;
            prod3.FechaInicioOferta = DateTime.Parse("25/12/2021 20:00:00 ");
            prod3.FechaFinOferta = DateTime.Parse("31/12/2021 20:00:00 ");
            prod3.PorcDescuentoEntreDosYCinco = 0.05f;
            prod3.PorcDescuentoEntreSeisYDiez = 0.10f;
            prod3.PorcDescuentoMasDeDiez = 0.13f;

            ListaProductos.Add(prod3);
            

            /*
             * JSON RECIBIDO DEL GRUPO 3, DEJO DECLARADO LAS INSTANCIAS PREVIAS ARRIBA PORQUE USA ESAS EN LAS PRUEBAS DE ACEPTACION
             * 
            string productos;
            TextReader ListaDeProductos = new StreamReader(@"C:\Users\reylu\Documents\FACULTAD\3ER AÑO\DISEÑO DE SISTEMAS\jsonProductosTeamTres.txt");
            productos = ListaDeProductos.ReadLine();
            ListaProductos = JsonConvert.DeserializeObject<List <Productos>> (productos);

            */

            //agrego descuentos
            Descuento dto1 = new Descuento();
            dto1.CodigoDto = "MatesDSI";
            dto1.PorcentajeDto = 0.30f;
            Descuentos.Add(dto1);

            Descuento dto2 = new Descuento();
            dto2.CodigoDto = "DSI";
            dto2.PorcentajeDto = 0.40f;
            Descuentos.Add(dto2);


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
                        
                        
                        foreach (Productos p in ListaProductos)
                        {
                            if (productoelegido == p.Id && cantidad <= p.StockDisponible)
                            {
                                carrito1.agregarProductos(p,cantidad);
                                carrito1.calcularImporteTotal();

                                p.StockDisponible = p.StockDisponible - cantidad;
                                Console.WriteLine("PRODUCTOS AGREGADOS CORRECTAMENTE");
                            }
                            else
                            if(productoelegido == p.Id && cantidad > p.StockDisponible)
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

                        bool ban1 = false ; 
                        int indice = 0; //indice que voy a eliminar de la lista
                        int contador = -1; // cuento las posiciones de la lista

                        foreach (ItemProducto prod in carrito1.ProductoSeleccionados)
                        {
                            contador++;

                            if (prod.Producto.Id == prodeliminar)
                            {
                                ban1 = carrito1.eliminarProductos(prod, cantidadEliminar);
                                indice = contador;
                                carrito1.calcularImporteTotal();
                                prod.Producto.StockDisponible = prod.Producto.StockDisponible + cantidadEliminar;
                                Console.WriteLine("Cantidad eliminada correctamente");                                
                            }

                        }

                        if (ban1 == true)
                        {
                            carrito1.ProductoSeleccionados.RemoveAt(indice);
                        }

                        break;

                    case 3:
                        Console.WriteLine("Ingrese el codigo de descuento: ");
                        string codigosDTO = Console.ReadLine();


                        foreach (Descuento desc in Descuentos)
                        {
                            if (codigosDTO == desc.CodigoDto)
                            {
                                carrito1.aplicarDescuento(desc);
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
                        carrito1.generarJson();
                        
                        ban = 1;
                        break;

                }

            }

        }

    }

}


