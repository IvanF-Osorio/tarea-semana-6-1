using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarea_dado_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = 0, dado2 = 0, total = 0, ciclos = -1, turnos = -1, dobles = 0, vidas = 3;
            string continuar = "s";

            while (continuar == "s" && vidas <= 3 && vidas != 0)
            {

                dado2 = aleatorio.Next(1, 7);
                dado1 = aleatorio.Next(1, 7);
                turnos += 1;
                ciclos += 1;
                total += dado1;
                if (vidas >= 3) vidas = 3;
                if (ciclos == 2) { vidas -= 1; ciclos = 0; }
                if (vidas == 0) { continuar = "n"; Console.WriteLine("####PERDIO####"); break; }
                if (turnos == 3)
                {
                    turnos = 0;
                    total += dado2;
                    if (dado1 == dado2) vidas += 1;

                    Console.WriteLine("Su dado es =" + dado1);
                    Console.WriteLine("Su segundo es =" + dado2);
                    Console.WriteLine("total = " + total);
                    Console.WriteLine("Sus vidas son = " + vidas);
                    Console.Write("Desea continuar (s/n):");
                    continuar = Console.ReadLine();
                }
                else
                {

                    Console.WriteLine("Su dado es =" + dado1);
                    Console.WriteLine("El ciclo es = " + ciclos);
                    Console.WriteLine("total = " + total);
                    Console.WriteLine("Sus vidas son = " + vidas);
                    Console.Write("Desea continuar (s/n):");
                    continuar = Console.ReadLine();
                }



            }

            Console.WriteLine("Gracias por participar");
            Console.WriteLine("Su total fue = " + total + " Puntos");
        }
    }
}
