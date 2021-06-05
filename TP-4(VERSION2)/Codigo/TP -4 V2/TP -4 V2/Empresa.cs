using System;
using System.Collections.Generic;
using System.Text;

namespace TP__4_V2
{
    class Empresa
    {
        private string razonSocial;
        private long cuit;
        private string domicilio;
        private string localidad;
        private string email;
        private long telefono;
         //VER 
        private List<Persona> empleados;
        private Actividad actividadRealizada;

        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public long Cuit { get => cuit; set => cuit = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string Email { get => email; set => email = value; }
        public long Telefono { get => telefono; set => telefono = value; }
        internal List<Persona> Empleados { get => empleados; set => empleados = value; }
        internal Actividad ActividadRealizada { get => actividadRealizada; set => actividadRealizada = value; }


        public void AsignarFecha(Persona persona)
        {
            int fechaAut;
            Console.WriteLine("Ingrese la fecha hasta que esta utorizado el empleado" +persona.Nombre_apellido +  ":  ");
            fechaAut = int.Parse(Console.ReadLine());
            persona.FechaAutorizacion = fechaAut ;

        }
    }
}
