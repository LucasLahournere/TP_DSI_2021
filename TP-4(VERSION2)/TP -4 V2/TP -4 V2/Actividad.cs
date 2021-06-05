using System;
using System.Collections.Generic;
using System.Text;

namespace TP__4_V2
{
    class Actividad
    {
        private Boolean autorizacion;
        private string nombre;
        private List<Empresa> empresas;

        public bool Autorizacion { get => autorizacion; set => autorizacion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        internal List<Empresa> Empresas { get => empresas; set => empresas = value; }


    }
}
