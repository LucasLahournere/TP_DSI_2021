using System;
using System.Collections.Generic;

namespace TP__4_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personasAutorizadas = new List<Persona>();
            List<Persona> personas = new List<Persona>();

            //----------------

            Actividad actividad1 = new Actividad();
            actividad1.Autorizacion = true;
            actividad1.Nombre_actividad = "Salud";

            Actividad actividad2 = new Actividad();
            actividad2.Autorizacion = true;
            actividad2.Nombre_actividad = "Transporte";

            Actividad actividad3 = new Actividad();
            actividad3.Autorizacion = true;
            actividad3.Nombre_actividad = "Seguridad";

            Actividad actividad4 = new Actividad();
            actividad4.Autorizacion = false;
            actividad4.Nombre_actividad = "Venta Ropa";

            //-------------- INSTANCIO PERSONAS

            Persona persona1 = new Persona();
            persona1.Nombre_apelido = "Lucas Lahournere";
            persona1.Dni = 43132940;
            persona1.Domicilio = "Alberdi 1456";
            persona1.Telefono = 15579733;
            persona1.Email = "1@email";
            persona1.Actividad_realizada = actividad1;
            personas.Add(persona1);

            Persona persona2 = new Persona();
            persona2.Nombre_apelido = "Tomas Lahournere";
            persona2.Dni = 40000000;
            persona2.Domicilio = "Alberdi 1456";
            persona2.Telefono = 15579733;
            persona2.Email = "2@email";
            persona2.Actividad_realizada = actividad2;
            personas.Add(persona2);

            Persona persona3 = new Persona();
            persona3.Nombre_apelido = "Diego Lahournere";
            persona3.Dni = 43333333;
            persona3.Domicilio = "Alberdi 1456";
            persona3.Telefono = 15579733;
            persona3.Email = "3@email";
            persona3.Actividad_realizada = actividad3;
            personas.Add(persona3);

            Persona persona4 = new Persona();
            persona4.Nombre_apelido = "Nai Figueroa";
            persona4.Dni = 43136678;
            persona4.Domicilio = "Alberdi 1456";
            persona4.Telefono = 15579733;
            persona4.Email = "4@email";
            persona4.Actividad_realizada = actividad4;
            personas.Add(persona4);


            int ban = 1;

            while (ban  == 1)
            {
                int op;

                Console.WriteLine("INGRESE LA OPCION");
                Console.WriteLine("1- Agregar persona");
                Console.WriteLine("2- Verificar persona");
                Console.WriteLine("3- Finalizar programa");

                Console.WriteLine("INGRESE LA OPCION");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        int op1;
                        Persona personax = new Persona();

                        Console.WriteLine("Ingrese el nombre y apellido: ");
                        personax.Nombre_apelido = Console.ReadLine();

                        Console.WriteLine("Ingrese el dni: ");
                        personax.Dni = long.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el domicilio: ");
                        personax.Domicilio= Console.ReadLine();

                        Console.WriteLine("Ingrese el telefono: ");
                        personax.Telefono = long.Parse(Console.ReadLine());

                        Console.WriteLine("Ingrese el email: ");
                        personax.Email = Console.ReadLine();

                        Console.WriteLine("Seleccione la actividad: ");
                        Console.WriteLine("1-Salud");
                        Console.WriteLine("2-Transporte");
                        Console.WriteLine("3-Seguridad");
                        Console.WriteLine("4-Venta Ropa");
                        
                        op1 = int.Parse(Console.ReadLine());

                        switch (op1)
                        {
                            case 1:
                                personax.Actividad_realizada = actividad1;
                                personas.Add(personax);
                                break;
                            case 2:
                                personax.Actividad_realizada = actividad2;
                                personas.Add(personax);
                                break;
                            case 3:
                                personax.Actividad_realizada = actividad3;
                                personas.Add(personax);
                                break;
                            case 4:
                                personax.Actividad_realizada = actividad4;
                                personas.Add(personax);
                                break;
                        }

                        break;
                    case 2:
                        long dni;
                        Console.WriteLine("Ingrese el DNI de la persona a verificar: ");
                        dni = long.Parse(Console.ReadLine());

                        foreach (Persona per in personas)
                        {
                            if (dni == per.Dni)
                            {
                                if (per.Actividad_realizada.Autorizacion == true)
                                {
                                    //Console.WriteLine("PERSONA AUTORIZADA");
                                    //per.Mostrar_persona();
                                    personasAutorizadas.Add(per);
                                    break;
                                }
                                else if (per.Actividad_realizada.Autorizacion == false)
                                {
                                    Console.WriteLine("PERSONA NO AUTORIZADA");
                                    break;
                                }
                            }
                            else if (dni != per.Dni && per.Actividad_realizada.Autorizacion == false)
                            {
                                Console.WriteLine("Persona no existe");
                            }
                        }

                        foreach (Persona persaut in personasAutorizadas)
                        {
                            if (dni == persaut.Dni)
                            {
                                Console.WriteLine("PERSONA AUTORIZADA");
                                persaut.Mostrar_persona();
                            }  
                        }
                        break;

                    case 3:
                        Console.WriteLine("Programa finalizado");
                        ban = 0;

                        break;
                    default:
                        Console.WriteLine("Opcion no disponible");
                        ban = 0; 
                        break;
                }
            }
            
        }
    }
}
