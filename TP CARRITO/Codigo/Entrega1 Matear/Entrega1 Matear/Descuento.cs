using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega1_Matear
{
    class Descuento
    {
        string codigoDto;
        float porcentajeDto;
        List<CarritoDeCompras> descuentos;


        public string CodigoDto { get => codigoDto; set => codigoDto = value; }
        public float PorcentajeDto { get => porcentajeDto; set => porcentajeDto = value; }
        internal List<CarritoDeCompras> Descuentos { get => descuentos; set => descuentos = value; }


    }
}
