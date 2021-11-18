using System;
using Xunit;
using Entrega1_Matear;
using System.Collections.Generic;
using System.Text;

namespace TestCarrito
{
    public class AplicarDescuento
    {

        [Fact]

        public void ValidarDescuentos()
        {
            CarritoDeCompras carrito = new CarritoDeCompras();

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
            p3.EstaEnOferta = true;
            p3.FechaInicioOferta = DateTime.Parse("20/12/2021 20:00:00");
            p3.FechaFinOferta = DateTime.Parse("31/12/2021 20:00:00 ");
            p3.PrecioOferta = 0.50f;
            p3.PorcDescuentoEntreDosYCinco = 0.01f;
            p3.PorcDescuentoEntreSeisYDiez = 0.03f;
            p3.PorcDescuentoMasDeDiez = 0.06f;


            Descuento dto = new Descuento();
            dto.PorcentajeDto = 0.5f;
            dto.CodigoDto = "Prueba";


            carrito.agregarProductos(p1, 1);
            carrito.agregarProductos(p1, 9);
            carrito.agregarProductos(p2, 6);
            carrito.agregarProductos(p3, 1);

            carrito.calcularImporteTotal();

            carrito.aplicarDescuento(dto);

            bool esValido = carrito.MontoTotal == 338.75f;

            Assert.True(esValido);

        }

    }

}

