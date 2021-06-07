using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25Version01
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroMayor=0, numeroMedio=0, numeroMenor=0;
            int primerNumero, segundoNumero, tercerNumero;
            int opcionSeleccionada;
            Console.Clear();
            Console.WriteLine("Seleccione Orden");

            Console.WriteLine("1-De mayor a menor");
            Console.WriteLine("2-De menor a mayor");
            Console.Write("Ingrese la selección:");
            opcionSeleccionada = Convert.ToInt32(Console.ReadLine());
            if (opcionSeleccionada>=1 && opcionSeleccionada<=2)
            {
                Console.Write("Ingrese el primer número:");
                primerNumero = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el segundo número:");
                segundoNumero = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese el tercer número:");
                tercerNumero = Convert.ToInt32(Console.ReadLine());
                if (primerNumero!=segundoNumero && segundoNumero!=tercerNumero && primerNumero!=tercerNumero)
                {
                    if (opcionSeleccionada==1)
                    {
                        OrdernarNumerosDesc(primerNumero, segundoNumero, tercerNumero,ref numeroMayor, ref numeroMedio,ref numeroMenor);
                    }
                    else
                    {
                        OrdenarNumeroAsc(primerNumero, segundoNumero, tercerNumero,ref numeroMayor,ref numeroMedio,ref numeroMenor);
                    }
                    ImprimirEnOrden(opcionSeleccionada, numeroMayor, numeroMedio, numeroMenor);

                }
                else
                {
                    Console.WriteLine("Se han ingresado números iguales");
                }
            }
            else
            {
                Console.WriteLine("Seleccion errónea... Fin del Algoritmo");
            }

            Console.ReadLine();
        }

        private static void ImprimirEnOrden(int opcionSeleccionada, int numeroMayor, int numeroMedio, int numeroMenor)
        {
            if (opcionSeleccionada==1)
            {
                Console.WriteLine(numeroMayor);
                Console.WriteLine(numeroMedio);
                Console.WriteLine(numeroMenor);
            }
            else
            {
                Console.WriteLine(numeroMenor);
                Console.WriteLine(numeroMedio);
                Console.WriteLine(numeroMayor);
            }
        }

        private static void OrdenarNumeroAsc(int numero1, int numero2, int numero3, ref int numeroMayor, ref int numeroMedio, ref int numeroMenor)
        {
            if (numero1<numero2)
            {
                if (numero1<numero3)
                {
                    numeroMenor = numero1;
                    if (numero2<numero3)
                    {
                        numeroMedio = numero2;
                        numeroMayor = numero3;
                    }
                    else
                    {
                        numeroMedio = numero3;
                        numeroMayor = numero2;
                    }
                }
                else
                {
                    numeroMenor = numero3;
                    numeroMedio = numero1;
                    numeroMayor = numero2;
                }
            }
            else
            {
                if (numero2<numero3)
                {
                    numeroMenor = numero2;
                    if (numero1<numero3)
                    {
                        numeroMedio = numero1;
                        numeroMayor = numero3;
                    }
                    else
                    {
                        numeroMedio = numero3;
                        numeroMayor = numero1;
                    }
                }
                else
                {
                    numeroMenor = numero3;
                    numeroMedio = numero2;
                    numeroMayor = numero1;
                }
            }

        }

        private static void OrdernarNumerosDesc(int numero1, int numero2, int numero3, ref int numeroMayor, ref int numeroMedio, ref int numeroMenor)
        {
            if (numero1 > numero2)
            {
                if (numero1 > numero3)
                {
                    numeroMayor = numero1;
                    if (numero2 > numero3)
                    {
                        numeroMedio = numero2;
                        numeroMenor = numero3;
                    }
                    else
                    {
                        numeroMedio = numero3;
                        numeroMenor = numero2;
                    }
                }
                else
                {
                    numeroMayor = numero3;
                    numeroMedio = numero1;
                    numeroMenor = numero2;
                }
            }
            else
            {
                if (numero2 > numero3)
                {
                    numeroMayor = numero2;
                    if (numero1 > numero3)
                    {
                        numeroMedio = numero1;
                        numeroMenor = numero3;
                    }
                    else
                    {
                        numeroMedio = numero3;
                        numeroMenor = numero1;
                    }
                }
                else
                {
                    numeroMayor = numero3;
                    numeroMedio = numero2;
                    numeroMenor = numero1;
                }
            }
        }
    }
}
