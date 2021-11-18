using System;
using System.Collections.Generic;
using System.Text;

namespace Entrega1_Matear
{
    class ProductosDTO
    {
      
        int id;
        float precioUnitario;
        int stockDisponible;
        string descripcion;

        public int Id { get => id; set => id = value; }
        public float PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public int StockDisponible { get => stockDisponible; set => stockDisponible = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        
    }
}
