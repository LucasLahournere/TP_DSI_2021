using System;
using System.Collections.Generic;
using System.Text;

namespace TP__4_V1
{
    class Persona
    {
        private long dni;
        private string nombre_apelido;
        private string domicilio;
        private long telefono;
        private string email;
        private Actividad actividad_realizada;

        public long Dni { get => dni; set => dni = value; }
        public string Nombre_apelido { get => nombre_apelido; set => nombre_apelido = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public long Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public Actividad Actividad_realizada { get => actividad_realizada; set => actividad_realizada = value; }



       public void Mostrar_persona()
        {
            
            Console.WriteLine("Nombre: " +nombre_apelido);
            Console.WriteLine("Dni: " + dni);
            Console.WriteLine("Domicilio: " + domicilio);
            Console.WriteLine("Email: "+ email);
            Console.WriteLine("Telefono: "+ telefono);
            Console.WriteLine("Actividad Realizada: " + actividad_realizada.Nombre_actividad );
            
            Console.WriteLine("---------------------------");
        }

        
    }

}
