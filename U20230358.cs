using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {

            
            string? universidad = "";

            string facultad = "Ingenieria y Arquitectura";
            string profesion = "Estudiante de Tec. En Desarrollo de Software";


            int anioIngreso = 0;
                        
            int edadIngreso = 19;
            int edadEgreso = 21;

            double cuotaUniversidad = 0.0;

            double gastoTransporte = 35.50;

            Console.WriteLine("\n---->Capturando datos de tipo texto<---------");
            Console.WriteLine("Inrgese el nombre de la universidad donde estudia >> ");
            universidad=Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n-----Fin de captura de tipo texto ------------\n");


            Console.WriteLine("\n------>Capturando datos de tipo entero<---------\n");
            Console.WriteLine("Ingrese el año que inicio la universidad >>");
            anioIngreso=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n----->Fin de captura de tipo enteros<--------\n");


            Console.WriteLine("\n------>Capturando datos de tipo decimal<---------\n");
            Console.WriteLine("Ingrese la cuota de la universidad >>");
            cuotaUniversidad=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n-----Fin de captura de tipo decimal----");

            Console.WriteLine("\n------->IMPRESION DE DATOS DE TIPO TEXTO<-------");
            Console.WriteLine("\n La universidad en la que estudia es >> " + universidad);
            Console.WriteLine("\n Pertenece a la facultad de >> " + facultad);
            Console.WriteLine("\n Estudiando la carrera de >>" + profesion);


            Console.WriteLine("\n------->IMPRESION DE DATOS DE ENTERO<-------");
            Console.WriteLine("\n El año que ingreso a la universidad fue >> " + anioIngreso);
            Console.WriteLine("\n La edad cuando inicio sus estudios es >> " + edadIngreso + "años");
            Console.WriteLine("\n La edad cuando finalice sus estudios sera >>" + edadEgreso + "años");


            Console.WriteLine("\n------->IMPRESION DE DATOS DE DOUBLE<-------");
            Console.WriteLine("\n La cuota de su universidad es >> " + "$" + cuotaUniversidad);
            Console.WriteLine("\n Su gasto en transporte es >> " + "$" + gastoTransporte);


            Console.ReadKey();
        }
    }
}