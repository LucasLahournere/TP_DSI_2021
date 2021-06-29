using System;
using System.Collections.Generic;
using System.Text;

namespace TP_4_VERSION3_
{
    class Persona
    {
        private long dni;
        private string nombre_apellido;
        private string domicilio;
        private long telefono;
        private string email;
        private DateTime fechaAutorizacion;
        private DateTime fechaIngreso;
        private float temperatura;
        private String patente;
        private string destino;
        private DateTime? hora_salida;
        private Empresa empresa;
        

        public long Dni { get => dni; set => dni = value; }
        public string Nombre_apellido { get => nombre_apellido; set => nombre_apellido = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public long Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public DateTime FechaAutorizacion { get => fechaAutorizacion; set => fechaAutorizacion = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public float Temperatura { get => temperatura; set => temperatura = value; }
        public string Patente { get => patente; set => patente = value; }
        public string Destino { get => destino; set => destino = value; }
        public DateTime? Hora_salida { get => hora_salida; set => hora_salida = value; }
        internal Empresa Empresa { get => empresa; set => empresa = value; }

        public void MostrarPersona()
        {
            Console.WriteLine("Nombre: " + nombre_apellido);
            Console.WriteLine("Dni: " + dni);
            Console.WriteLine("Domicilio: " + domicilio);
            Console.WriteLine("Telefono: " + telefono);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Fecha Hasta que esta autorizado: " + fechaAutorizacion);
            Console.WriteLine("Pertenece a la empresa: " + empresa.Cuit);
            Console.WriteLine("La fecha de ingreso es : " + fechaIngreso);
            Console.WriteLine("La temperatura es: "+temperatura);
            Console.WriteLine("El destino es: "+ destino);
            Console.WriteLine("La patente es: "+ patente);
            Console.WriteLine("La fecha de salida es: "+ hora_salida);

            Console.WriteLine("----------------------------------------------------------------");

        }
    }
}
