using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ejerciciosConArray
{
    class TrabajarSobreArraysDesdeEj7
    {

        //7
        public void PedirSueldos()
        {
            bool esNegativo = true;
            string [] nombre = new string[5];
            double[] sueldo = new double[5];
            while (esNegativo)
                esNegativo = false;
            {
                Console.WriteLine("Ingresar nombre de empleado luego sueldo separados por espacio: ");
                string[] ingreso = Console.ReadLine().Split(" ");
                int contador = 0;
                foreach (string ing in ingreso)
                {
                    
                    if (contador % 2 == 0)
                    {
                        nombre[contador] = ing;
                    }
                    else
                    {
                        if (double.Parse(ing) < 0)
                        {
                            esNegativo = true;
                        }
                        sueldo[contador-1] = double.Parse(ing);
                    }
                    contador++;
                }
            }
            ImplimirSueldos(nombre, sueldo);
            
        }

        public void ImplimirSueldos(string[] nombres, double [] sueldos)
        {
            int i = 0;
            foreach (string resultado in nombres)
            {
                Console.WriteLine($"El sueldo de {nombres[i]} es: ${sueldos[i]}");
                i++;
            }
        }


        //8

        public void PromedioAlumnos(double[,] calificaciones, ArrayList nombres)
        {
            double resultado = 0;
            int contador = 1;
            ArrayList promedio = new ArrayList();
            foreach (double arr in calificaciones)
            {
                resultado += arr;
                if (contador == 10)
                {
                    promedio.Add(resultado/10);
                    contador = 0;
                    resultado = 0;
                }
                contador++;
            }
            promedio.Add(resultado / 10);
            contador = 0;
            foreach (Object imp in nombres)
            {
                Console.WriteLine($"Promedio de {imp}: " + promedio[contador]);
                contador++;
            }
        }

        public void CalificacionMaxima(double[,] calificaciones, ArrayList nombres)
        {
            double masAlta = 0;
            int contador = 1;
            ArrayList notaMasAlta = new ArrayList();
            foreach (double arr in calificaciones)
            {
                if (arr > masAlta)
                {
                    masAlta = arr;
                }
                if (contador == 10)
                {
                    notaMasAlta.Add(masAlta);
                    contador = 0;
                    masAlta = 0;
                }
                contador++;
            }
            contador = 0;
            foreach (Object arr in nombres)
            {
                Console.WriteLine($"Nota mas alta de {arr} es: " + notaMasAlta[contador]);
                contador++;
            }
        }

        public void CalificacionMinima(double[,] calificaciones, ArrayList nombres)
         {
            double masBaja = 100000000;
            int contador = 1;
            ArrayList notaMasBaja = new ArrayList();
            foreach (double arr in calificaciones)
            {
                if (arr < masBaja)
                {
                    masBaja = arr;
                }
                if (contador == 10)
                {
                    notaMasBaja.Add(masBaja);
                    contador = 0;
                    masBaja = 10000000000;
                }
                contador++;
            }
            contador = 0;
            foreach (Object arr in nombres)
            {
                Console.WriteLine($"Nota mas baja de {arr} es: " + notaMasBaja[contador]);
                contador++;
            }
        }

        //9

        public void Diccionario()
        {

        }

    }
}
