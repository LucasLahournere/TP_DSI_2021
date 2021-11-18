using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega1_Matear
{
    public class CarritoDeComprasDTO
    {
        string fechaCompra;
        float montoTotal;


        public float MontoTotal { get => montoTotal; set => montoTotal = value; }
        public string FechaCompra { get => fechaCompra; set => fechaCompra = value; }
    }
}
