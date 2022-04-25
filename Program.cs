using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Registrar alumnos?");
            string Respuesta = "si";
            List<Alumno> listAlumnos = new();//SE CREA UNA LISTA TIPO CLASE

            while (Respuesta != "no")
            {
                Alumno alumno = new();

                Console.WriteLine("Ingrese nombre de alumno");
                alumno.Nombre = Console.ReadLine();//SE ENIVA A LA LISTA EL ATRIBUTO.
                Console.WriteLine("Ingrese Tipo de Documento");
                alumno.TipoDocumento = Console.ReadLine();
                Console.WriteLine("Digite el Documento");
                alumno.Documento = Console.ReadLine();

                //se crea el while para  llenar las materias

                do //ciclo para llenar N cantidades de materias
                {
                    Materia materia = new();
                    Console.WriteLine("Ingrese el nombre de la materia que desea agregar");
                    materia.NombreMateria = Console.ReadLine();

                    Console.WriteLine("Ingrese las horas");
                    materia.HoraMateria = Console.ReadLine();
                    alumno.listaMaterias.Add(materia);

                    Console.WriteLine("Desea registrar mas Materias ? :");//Pregunta para que se pueda repetir N cantidad de veces el llenado de la materia
                    Respuesta = Console.ReadLine();
                } while (Respuesta != "no");
                listAlumnos.Add(alumno);// aca agrega el alumno a la lista del alumno


                Console.WriteLine("Desea registrar mas alumnos?:"); //final del registro
                Respuesta = Console.ReadLine();
            }

            Console.WriteLine("La cantidad de alumnos registrados son: " + listAlumnos.Count);// NOMBRE DE LA LISTA Y EL COUNT SIRVE PARA CONTAR LA CANTIDAD DE LA LISTA 

            foreach (var alumno in listAlumnos)
            {
                Console.WriteLine("Nombre del alumno: " + alumno.Nombre + "\nTipo de documento: " + alumno.TipoDocumento + "\nDocumento: " + alumno.Documento);
                foreach (var materia in alumno.listaMaterias) //de aca se sacan las materias por cada alumno y las horas
                {
                    Console.WriteLine(" El nombre de la materia : " + materia.NombreMateria + " y las horas de esta son : " + materia.HoraMateria);
                }
            }

            listAlumnos.ForEach(alumno => Console.WriteLine(alumno.Nombre));//CONSULTA LINQ

        }
    }
}
