using System;
using System.Collections.Generic;
using System.Text;

namespace TP__4_V2
{
    class Persona
    {
        private long dni;
        private string nombre_apellido;
        private string domicilio;
        private long telefono;
        private string email;
        private DateTime fechaAutorizacion;
        private Empresa empresa;

        public long Dni { get => dni; set => dni = value; }
        public string Nombre_apellido { get => nombre_apellido; set => nombre_apellido = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public long Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public DateTime FechaAutorizacion { get => fechaAutorizacion; set => fechaAutorizacion = value; }
        internal Empresa Empresa { get => empresa; set => empresa = value; }

        public void MostrarPersona()
        {
            Console.WriteLine("Nombre: " + nombre_apellido);
            Console.WriteLine("Dni: " + dni);
            Console.WriteLine("Domicilio: "+domicilio);
            Console.WriteLine("Telefono: " + telefono);
            Console.WriteLine("Email: "+ email);
            Console.WriteLine("Fecha Hasta que esta autorizado: " +fechaAutorizacion);
            Console.WriteLine("Pertenece a la empresa: " + empresa.Cuit) ;

            Console.WriteLine("----------------------------------------------------------------");

        }
    }
}
