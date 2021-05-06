using System;
using System.Collections.Generic;
using System.Text;

namespace TP__4_V1
{
    class Actividad
    {
        private Boolean autorizacion;
        private string nombre_actividad;
        private List<Persona> personas;

        public bool Autorizacion { get => autorizacion; set => autorizacion = value; }
        public string Nombre_actividad { get => nombre_actividad; set => nombre_actividad = value; }
        internal List<Persona> Personas { get => personas; set => personas = value; }


    }
}



