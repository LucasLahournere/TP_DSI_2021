using System;
using System.Collections.Generic;
using Xunit;
using Entrega1_Matear;
using System.Text;
using System.IO;

namespace TestCarrito
{
    public class CalcularImportePorCantidad
    {
        [Fact]
        public void ValidarGeneracionJson()
        {
            CarritoDeCompras carrito = new CarritoDeCompras();

            Productos p1 = new Productos();
            p1.Id = 1;
            p1.PrecioUnitario = 50f;
            p1.StockDisponible = 100;
            p1.EstaEnOferta = false;
            p1.FechaInicioOferta = DateTime.Parse("6/11/2021 20:00:00 ");
            p1.FechaFinOferta = DateTime.Parse("31/12/2021 20:00:00 ");
            p1.PrecioOferta = 0.10f;
            p1.PorcDescuentoEntreDosYCinco = 0.01f;
            p1.PorcDescuentoEntreSeisYDiez = 0.03f;
            p1.PorcDescuentoMasDeDiez = 0.06f;

            Productos p2 = new Productos();
            p2.Id = 2;
            p2.PrecioUnitario = 55f;
            p2.StockDisponible = 100;
            p2.EstaEnOferta = false;
            p2.FechaInicioOferta = DateTime.Parse("6/11/2021 20:00:00 ");
            p2.FechaFinOferta = DateTime.Parse("31/12/2021 20:00:00 ");
            p2.PrecioOferta = 0.10f;
            p2.PorcDescuentoEntreDosYCinco = 0.1f;
            p2.PorcDescuentoEntreSeisYDiez = 0.3f;
            p2.PorcDescuentoMasDeDiez = 0.6f;

            Productos p3 = new Productos();
            p3.Id = 3;
            p3.PrecioUnitario = 10f;
            p3.StockDisponible = 100;
            p3.EstaEnOferta = false;
            p3.FechaInicioOferta = DateTime.Parse("20/12/2021 20:00:00");
            p3.FechaFinOferta = DateTime.Parse("31/12/2021 20:00:00 ");
            p3.PrecioOferta = 0.50f;
            p3.PorcDescuentoEntreDosYCinco = 0.01f;
            p3.PorcDescuentoEntreSeisYDiez = 0.03f;
            p3.PorcDescuentoMasDeDiez = 0.06f;


            carrito.agregarProductos(p1,6);
            carrito.agregarProductos(p3,12);
            carrito.agregarProductos(p1,10);
            carrito.agregarProductos(p2,4);

            carrito.calcularImporteTotal();

            bool esValido = carrito.MontoTotal == 1062.8f;

            Assert.True(esValido);

        }

        
    }
}
