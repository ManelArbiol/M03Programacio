using System;
/*
 * Author: Manel Arbiol Calpe
 * T1. Activits. Introducció a la Programació
 * 29/09/2024
 * Exercici 18 .
 * 18. Especifica un algorisme que demani per teclat 20 valors enters i que els emmagatzemi segons les següents indicacions: 
●	si el nombre és divisible per 5, +3 al nombre rebut 
●	si el nombre és divisible per 3, -2 al nombre rebut 
●	en cas contrari, emmagatzemar el valor rebut

Un cop finalitzat, mostrar el resultat per pantalla.
 *
 */
namespace PrimerTemaActivitats
{
    public class AlotOperations
    {
        static void Main(string[] args)
        {

            //constantes
            const string TXT_NUMBER = "Escriu 20 numeros: ";
            const string NUM_DIV_FIVE = "El numero es divisible per 5, per tant +3 al numero, resultat: ";
            const string NUM_DIV_THREE = "El numero es divisible per 3, per tant -2 al numero, resultat: ";
            const string NUM_NO_DIV = "El numero no es divisible ni per 5 ni per 3, per tant el mateix numero: ";
            const string SUMA_TOTAL_DIV_FIVE = "La suma de tots els numeros que son divisibles per 5 és: ";
            const string SUMA_TOTAL_DIV_THREE = "La suma de tots els numeros que son divisibles per 3 és: ";
            const string SUMA_TOTAL_NORMAL = "La suma de tots els altres numeros és: ";


            int num, numDivFive = 0, numDivTree = 0, numNoDiv = 0;

            Console.WriteLine(TXT_NUMBER);

            for (int i = 0; i < 20; i++)
            {

                num = Convert.ToInt32(Console.ReadLine());

                if (num % 5 == 0)
                {


                    Console.WriteLine(NUM_DIV_FIVE + (num + 3));
                    numDivFive += num + 3;
                }
                else if (num % 3 == 0)
                {

                    Console.WriteLine(NUM_DIV_THREE + (num - 2));
                    numDivTree += num - 2;
                }
                else
                {

                    Console.WriteLine(NUM_NO_DIV + num);
                    numNoDiv += num;
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine(SUMA_TOTAL_DIV_FIVE + numDivFive + "\n");
            Console.WriteLine(SUMA_TOTAL_DIV_THREE + numDivTree + "\n");
            Console.WriteLine(SUMA_TOTAL_NORMAL + numNoDiv + "\n");
        }
    }
}