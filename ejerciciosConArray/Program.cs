using System;
using System.Collections;


namespace ejerciciosConArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //TrabajarSobreArray arrays = new TrabajarSobreArray();
            //1//double[,] arreglo2x2 = new double[2,2]{ { 2, 2 }, { 2, 2 } };
            //arrays.CalcularDeterminante2x2(arreglo2x2);
            //2//double[,] arreglo3x3 = new double[3, 3] { { 3, 3, 3 }, { 3, 3, 3 },{ 3,3,3} };
            //arrays.CalcularDeterminante3x3(arreglo3x3);
            //3//string[] nombres = new string[10] { "Hola","Como", "estas", "?","","","","","",""};
            //arrays.Menu();
            //arrays.TrabajarSobreMenu(nombres);
            //4//arrays.ImprimirStringCadaDosCaracters(arrays.PedirCadenaParImprimir());
            //5//arrays.dividirCadenaEnSubcadenas(arrays.PedirCadenaParImprimir());
            //6//arrays.sumarNumeros();

            TrabajarSobreArraysDesdeEj7 arraysDesdeEj7 = new TrabajarSobreArraysDesdeEj7();
            //7//arraysDesdeEj7.PedirSueldos();
            /*8//ArrayList alumnos = new ArrayList();
            alumnos.Add("PEPE");
            alumnos.Add("MANUEL");
            alumnos.Add("LAUTARO");
            alumnos.Add("MARTIN");
           
            double[,] calificaciones = new double[4,10] { {10,10,9,8,6,7,10,9,9,10 },
                                                          {5,6,5,6,6,7,8,5,6,5 },
                                                          {8,9,8,7,6,4,8,9,10,8 },
                                                          {10,10,10,10,10,10,9,10,9,10 } };
            arraysDesdeEj7.PromedioAlumnos(calificaciones, alumnos);
            arraysDesdeEj7.CalificacionMaxima(calificaciones, alumnos);
            arraysDesdeEj7.CalificacionMinima(calificaciones, alumnos);*/

            /*Hashtable diccionario = new Hashtable();
            diccionario.Add("Casa", "Construcción cubierta destinada a ser habitada.");
            diccionario.Add("Vaso", "Recipiente para líquidos u otras cosas, parecido al anterior, pero que no se usa para beber.");
            diccionario.Add("Mesa", "Mueble formado por un tablero horizontal, sostenido por uno o varios pies, con la altura conveniente para poder realizar alguna actividad sobre ella o dejar cosas encima.");
            diccionario.Add("Silla", "Asiento individual con patas y respaldo.");*/

            DateTime fecha = new DateTime(2021, 5, 2);
            Console.WriteLine(fecha);
              
        }
    }
}
