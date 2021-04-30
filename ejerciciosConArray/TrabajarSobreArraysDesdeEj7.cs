using System;
using System.Collections.Generic;
using System.Text;

namespace ejerciciosConArray
{
    class TrabajarSobreArraysDesdeEj7
    {

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
        

    }
}
