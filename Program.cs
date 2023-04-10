//Proyecto Final (pacientes con cancer, coño Paulo me hiciste hacer esto otra vez.)
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Paciente> pacientes = new List<Paciente>();

        while (true)
        {
            Console.WriteLine("Bienvenido al listado de pacientes con cáncer.");
            Console.WriteLine("1. Agregar paciente");
            Console.WriteLine("2. Editar paciente");
            Console.WriteLine("3. Borrar paciente");
            Console.WriteLine("4. Mostrar pacientes");
            //khvhjkgvjhgvjgyhjhbkbh
            Console.WriteLine("5. Salir");

            Console.Write("Ingrese una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el nombre del paciente: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Ingrese el tipo de cáncer: ");
                    string tipoCancer = Console.ReadLine();
                    Console.Write("Ingrese la fecha de diagnóstico (formato: dd/mm/aaaa): ");
                    DateTime fechaDiagnostico = DateTime.Parse(Console.ReadLine());

                    pacientes.Add(new Paciente(nombre, tipoCancer, fechaDiagnostico));
                    Console.WriteLine("Paciente agregado exitosamente.");
                    break;

                case 2:
                    Console.Write("Ingrese el número de paciente a editar: ");
                    int indiceEditar = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (indiceEditar < 0 || indiceEditar >= pacientes.Count)
                    {
                        Console.WriteLine("Número de paciente inválido.");
                    }
                    else
                    {
                        Console.Write("Ingrese el nuevo nombre del paciente: ");
                        pacientes[indiceEditar].Nombre = Console.ReadLine();
                        Console.Write("Ingrese el nuevo tipo de cáncer: ");
                        pacientes[indiceEditar].TipoCancer = Console.ReadLine();
                        Console.Write("Ingrese la nueva fecha de diagnóstico (formato: dd/mm/aaaa): ");
                        pacientes[indiceEditar].FechaDiagnostico = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Paciente editado exitosamente.");
                    }

                    break;

                case 3:
                    Console.Write("Ingrese el número del paciente:");
                    int indiceBorrar = Convert.ToInt32(Console.ReadLine()) - 1;

                    if (indiceBorrar < 0 || indiceBorrar >= pacientes.Count)
                    {
                        Console.WriteLine("Número de paciente inválido.");
                    }
                    else
                    {
                        pacientes.RemoveAt(indiceBorrar);
                        Console.WriteLine("Paciente borrado exitosamente.");
                    }

                    break;

                case 4:
                    Console.WriteLine("Listado de pacientes:");

                    for (int i = 0; i < pacientes.Count; i++)
                    {
                        Console.WriteLine("Paciente {0}:", i + 1);
                        Console.WriteLine("Nombre: {0}", pacientes[i].Nombre);
                        Console.WriteLine("Tipo de cáncer: {0}", pacientes[i].TipoCancer);
                        Console.WriteLine("Fecha de diagnóstico: {0}", pacientes[i].FechaDiagnostico.ToString("dd/MM/yyyy"));
                        Console.WriteLine();
                    }

                    break;

                case 5:
                    Console.WriteLine("Gracias por usar el listado de pacientes con cáncer.");
                    return;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            Console.WriteLine();
        }
    }
}

class Paciente
{
    public string Nombre { get; set; }
    public string TipoCancer { get; set; }
    public DateTime FechaDiagnostico { get; set; }

    public Paciente(string nombre, string tipoCancer, DateTime fechaDiagnostico)
    {
        Nombre = nombre;
        TipoCancer = tipoCancer;
        FechaDiagnostico = fechaDiagnostico;
    }
}

