using System;
using System.IO;

namespace Archivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreArchivo = "miarchivo.txt";
            string contenido = "Este es el contenido del archivo.";

            // Crear el archivo y escribir contenido en él
            try
            {
                using (StreamWriter sw = File.CreateText(nombreArchivo))
                {
                    sw.WriteLine(contenido);
                }

                Console.WriteLine($"Archivo '{nombreArchivo}' creado y contenido escrito con éxito.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocurrió un error al crear o escribir en el archivo: " + e.Message);
            }

            // Leer el archivo que acabamos de crear
            try
            {
                using (StreamReader sr = new StreamReader(nombreArchivo))
                {
                    string linea;
                    Console.WriteLine($"Contenido del archivo '{nombreArchivo}':");
                    while ((linea = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(linea);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocurrió un error al leer el archivo: " + e.Message);
            }

            try
            {
                // Pase la ruta del archivo y el nombre del archivo al StreamWriter Constructor
                StreamWriter sw = new StreamWriter("C:\\Test.txt");
                // Escribe una línea de t
                sw.WriteLine("Hello World!!");
                // Escribe una segunda línea de texto.
                sw.WriteLine("De la clase StreamWriter");
                //cerrar el archivo
                sw.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Ejecutando finalmente el bloque.");
            }
        }
    }
}
