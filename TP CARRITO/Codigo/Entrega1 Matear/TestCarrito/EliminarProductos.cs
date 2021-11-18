using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Entrega1_Matear;
using Xunit;

namespace TestCarrito
{
    public class EliminarProductos
    {
        [Fact]

        public void ValidarEliminacion()
        {
            CarritoDeCompras carrito = new CarritoDeCompras();
            carrito.FechaCompra = DateTime.Now;

            Productos p1 = new Productos();
            p1.Id = 1;
            p1.PrecioUnitario = 50f;
            p1.StockDisponible = 100;
            p1.EstaEnOferta = true;
            p1.FechaInicioOferta = DateTime.Parse("6/11/2021 20:00:00 ");
            p1.FechaFinOferta = DateTime.Parse("31/12/2021 20:00:00 ");
            p1.PrecioOferta = 0.10f;
            p1.PorcDescuentoEntreDosYCinco = 0.01f;
            p1.PorcDescuentoEntreSeisYDiez = 0.03f;
            p1.PorcDescuentoMasDeDiez = 0.06f;


            ItemProducto prod = new ItemProducto();
            prod.Producto = p1;

            carrito.agregarProductos(p1, 1);
            carrito.agregarProductos(p1, 9);

            carrito.eliminarProductos(prod,10);

            // si los productos se eliminaron, el monto del carrito va a ser 0
            bool esValido = carrito.MontoTotal == 0f;

            Assert.True(esValido);

        }


    }
}
