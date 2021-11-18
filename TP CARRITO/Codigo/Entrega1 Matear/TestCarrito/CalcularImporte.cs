using System;
using System.Collections.Generic;
using Xunit;
using System.Text;
using Entrega1_Matear;

namespace TestCarrito
{
    public class CalcularImporte
    {
        [Fact]
        public void ValidarImporte()
        {
            CarritoDeCompras carrito = new CarritoDeCompras();

            Productos p1 = new Productos();
            p1.Id = 1;
            p1.PrecioUnitario = 500f;
            p1.StockDisponible = 100;

            Productos p2 = new Productos();
            p2.Id = 2;
            p2.PrecioUnitario = 550f;
            p2.StockDisponible = 100;

            Productos p3 = new Productos();
            p3.Id = 3;
            p3.PrecioUnitario = 10f;
            p3.StockDisponible = 100;

            carrito.agregarProductos(p1, 1);
            carrito.agregarProductos(p1, 10);
            carrito.agregarProductos(p2, 15);
            carrito.agregarProductos(p3, 1);


            carrito.calcularImporteTotal();

            bool esValido = carrito.MontoTotal == 13760f;

            Assert.True(esValido);

        }

    }
}
