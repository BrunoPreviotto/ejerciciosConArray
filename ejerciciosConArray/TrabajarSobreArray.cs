using System;
using System.Collections.Generic;
using System.Text;

namespace ejerciciosConArray
{
    class TrabajarSobreArray
    {
        public double CalcularDeterminante2x2(double[,] arreglo)
        {
            return ((arreglo[0, 0] * arreglo[1, 1]) - (arreglo[1, 0] * arreglo[0, 1])); 
        }

        public double CalcularDeterminante3x3(double[,] arreglo)
        {
            return  ((arreglo[0, 0] * arreglo[1, 1] * arreglo[2, 2]) +
                     (arreglo[0, 1] * arreglo[1, 2] * arreglo[2, 0]) +
                     (arreglo[1, 0] * arreglo[2, 1] * arreglo[0, 2]) -
                     (arreglo[2, 0] * arreglo[1, 1] * arreglo[0, 2]) -
                     (arreglo[2, 1] * arreglo[1, 2] * arreglo[0, 0]) -
                     (arreglo[1, 0] * arreglo[0, 1] * arreglo[2, 2]));
        }

        public void Menu()
        {
            Console.WriteLine("MENU" + "\n" + 
                              "1-INSERTAR UN DATO" + "\n" +
                              "2-BORRAR UN DATO" +"\n"+
                              "3-SALIR");
        }

        public void TrabajarSobreMenu(string[] cadenaPorDefault)
        {
            Console.WriteLine("Ingresar una opcion: ");
            String ingreso = Console.ReadLine();
            while (!ingreso.Equals("3")) {
                switch (ingreso)
                {
                    case "1":
                        InsertarString(cadenaPorDefault);
                        break;
                    case "2":
                        BorrarString(cadenaPorDefault);
                        break;
                    default:
                        Console.WriteLine("Ingresar una opcion: ");
                        ingreso = Console.ReadLine();
                        break;

                }
            }
        }

        public void InsertarString(string[] cadena)
        {
            Console.WriteLine("Valor a inserta y posicion separados por coma: ");
            string [] insertar = Console.ReadLine().Split(",");

            
                if (Int32.Parse(insertar[1]) < cadena.Length && cadena[cadena.Length - 1].Equals(""))
                {
                    bool bandera = true;
                    int j = 0;
                    while (bandera)
                    {
                        if (cadena[j].Equals(""))
                        {
                            for (int s = 0; s <= (j- Int32.Parse(insertar[1])); s++)
                            {
                                cadena[j-s] = cadena[j-s-1];
                            }
                            bandera = false;
                        }
                        j++;
                    }

                    for (int i = 0; i < Int32.Parse(insertar[1]); i++)
                    {
                        cadena[Int32.Parse(insertar[1])] = insertar[0];
                    }

                }
            for(int i = 0; i < cadena.Length; i++)
            {
                Console.WriteLine(cadena[i]);
            }

            
        }

        public void BorrarString(string[] cadena)
        {

        }
    }
}
