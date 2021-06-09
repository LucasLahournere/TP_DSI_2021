using System;
using System.Collections.Generic;

namespace TP__4_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();
            List<Persona> personasaut = new List<Persona>();
            List<Persona> personasnoaut = new List<Persona>();
            List<Empresa> empresas = new List<Empresa>();


            // INSTANCIO ACTIVIDADES

            Actividad actividad1 = new Actividad();
            actividad1.Autorizacion = true;
            actividad1.Nombre= "Salud";

            Actividad actividad2 = new Actividad();
            actividad2.Autorizacion = true;
            actividad2.Nombre= "Transporte";

            Actividad actividad3 = new Actividad();
            actividad3.Autorizacion = true;
            actividad3.Nombre= "Seguridad";

            Actividad actividad4 = new Actividad();
            actividad4.Autorizacion = false;
            actividad4.Nombre= "Venta Ropa";

            // INSTANCIO EMPRESAS

            Empresa empresa1 = new Empresa();
            empresa1.RazonSocial = "SA";
            empresa1.Cuit = 66666;
            empresa1.Domicilio = "domicilio 1";
            empresa1.Localidad = "San Francisco";
            empresa1.Email = "empresa1@gmail.com";
            empresa1.Telefono = 3564599897;
            empresa1.ActividadRealizada = actividad1;
            empresas.Add(empresa1);
            

            Empresa empresa2 = new Empresa();
            empresa2.RazonSocial = "SA";
            empresa2.Cuit = 77777;
            empresa2.Domicilio = "domicilio 2";
            empresa2.Localidad = "Cordoba";
            empresa2.Email = "empresa2@gmail.com";
            empresa2.Telefono = 3564599897;
            empresa2.ActividadRealizada = actividad4;
            empresas.Add(empresa2);

            Empresa empresa3 = new Empresa();
            empresa3.RazonSocial = "SRL";
            empresa3.Cuit = 8888;
            empresa3.Domicilio = "domicilio 3";
            empresa3.Localidad = "Cordoba";
            empresa3.Email = "empresa3@gmail.com";
            empresa3.Telefono = 3564599897;
            empresa3.ActividadRealizada = actividad2;
            empresas.Add(empresa3);

            // INSTANCIO PERSONAS

            Persona persona1 = new Persona();
            persona1.Nombre_apellido = "Lucas Lahournere";
            persona1.Dni = 43132940;
            persona1.Domicilio = "Alberdi 1456";
            persona1.Telefono = 15579733;
            persona1.Email = "1@email";
            persona1.Empresa = empresa1;
            personas.Add(persona1);

            Persona persona2 = new Persona();
            persona2.Nombre_apellido = "Tomas Lahournere";
            persona2.Dni = 40000000;
            persona2.Domicilio = "Alberdi 1456";
            persona2.Telefono = 15579733;
            persona2.Email = "2@email";
            persona2.Empresa = empresa2;
            personas.Add(persona2);

            Persona persona3 = new Persona();
            persona3.Nombre_apellido = "Diego Lahournere";
            persona3.Dni = 43333333;
            persona3.Domicilio = "Alberdi 1456";
            persona3.Telefono = 15579733;
            persona3.Email = "3@email";
            persona3.Empresa = empresa3;
            personas.Add(persona3);


            Console.WriteLine("Asigne la fecha hasta que estan autorizados a los empleados: (Formato DD/FF/AÑO HS:MIN:SEG)");
            empresa1.AsignarFecha(persona1);
            empresa2.AsignarFecha(persona2);
            empresa3.AsignarFecha(persona3);

 
            int ban = 1;
            while (ban == 1)
            {
                int op;
                Console.WriteLine("Elija una opcion");
                Console.WriteLine("1- Cargar un empleado"); //LISTO
                Console.WriteLine("2- Evaluar autorizacion"); // LISTO 
                Console.WriteLine("3- Baja empleado"); // LISTO
                Console.WriteLine("4- Finalizar programa"); //LISTO

                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Persona persona4 = new Persona();

                        Console.WriteLine("Ingrese nombre del empleado: ");
                        persona4.Nombre_apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese dni: ");
                        persona4.Dni = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el domicilio");
                        persona4.Domicilio = Console.ReadLine();
                        Console.WriteLine("Ingrese el email");
                        persona4.Email = Console.ReadLine();
                        Console.WriteLine("Ingrese el telefono");
                        persona4.Telefono = long.Parse(Console.ReadLine());

                        int op1;

                        Console.WriteLine("¿A que empresa pertenece?: ");
                        Console.WriteLine("Empresa 1 ");
                        Console.WriteLine("Empresa 2 ");
                        Console.WriteLine("Empresa 3 ");
                        op1 = int.Parse(Console.ReadLine());

                        switch (op1)
                        {
                            case 1:
                                persona4.Empresa = empresa1;
                                Console.WriteLine("Asigne la fecha hasta que esta autorizado al empleado: (Formato DD/FF/AÑO HS:MIN:SEG)");
                                empresa1.AsignarFecha(persona4);
                                personas.Add(persona4);
                                break;
                            case 2:
                                persona4.Empresa = empresa2;
                                Console.WriteLine("Asigne la fecha hasta que esta autorizado al empleado: (Formato DD/FF/AÑO HS:MIN:SEG)");
                                empresa2.AsignarFecha(persona4);
                                personas.Add(persona4);
                                break;
                            case 3:
                                persona4.Empresa = empresa3;
                                Console.WriteLine("Asigne la fecha hasta que esta autorizado al empleado: (Formato DD/FF/AÑO HS:MIN:SEG)");
                                empresa3.AsignarFecha(persona4);
                                personas.Add(persona4);
                                break;
                        }
                        break;
                    case 2:
                        long dni1;
                        Persona personaautorizada = new Persona();
                        Persona personaNOautorizada =  new Persona();

                        Console.WriteLine("Ingrese el dni del empleado: ");
                        dni1 = long.Parse(Console.ReadLine());

                        DateTime today = DateTime.Today;

                        foreach (Persona per in personas)
                       {
                            if (dni1 == per.Dni && per.Empresa.ActividadRealizada.Autorizacion == true)
                            {
                                personaautorizada = per;
                            }
                            else if(dni1 == per.Dni && per.Empresa.ActividadRealizada.Autorizacion == false)
                            {
                                personaNOautorizada = per;

                            } 
  
                       }

                        // VER TEMA DE LAS FECHAS
                        if (dni1 == personaautorizada.Dni && DateTime.Compare(personaautorizada.FechaAutorizacion, today) > 0)
                        {
                            Console.WriteLine("El empleado esta autorizado");
                            personaautorizada.MostrarPersona();

                        }else if (dni1 == personaautorizada.Dni && DateTime.Compare(personaautorizada.FechaAutorizacion, today) < 0)
                        {
                            Console.WriteLine("La autorizacion del empleado esta vencida.");
                            personaautorizada.MostrarPersona();
                        } 
                        else if (dni1 == personaNOautorizada.Dni)
                        {
                            Console.WriteLine("El empleado  NO esta autorizado");

                        } else if (dni1 != personaautorizada.Dni && dni1 != personaNOautorizada.Dni)
                        {
                            Console.WriteLine("La persona no existe");
                        }

                        break;

                    case 3:
                        long dnieliminar;
                        Persona personaeliminar = new Persona();


                        Console.WriteLine("Que empleado quiere dar de baja? ");
                        Console.WriteLine("Inserte el dni: ");
                        dnieliminar = long.Parse(Console.ReadLine());

                        foreach (Persona pers in personas)
                        {
                            if (dnieliminar == pers.Dni)
                            {
                                personaeliminar = pers;
                            }

                        }

                        if (dnieliminar == personaeliminar.Dni)
                        {
                            personas.Remove(personaeliminar);
                            Console.WriteLine("Baja de empleado correcta");
                        }
                        else
                        {
                            Console.WriteLine("No existe ese empleado");
                        }
               
                        break;

                    case 4:
                        Console.WriteLine("PROGRAMA FINALIZADO");
                        ban = 0;
                        break;
                }
            }

        }
    }
}
