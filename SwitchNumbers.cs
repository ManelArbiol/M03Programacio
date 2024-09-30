using System;
/*
 * Author: Manel Arbiol Calpe
 * T1. Activits. Introducció a la Programació
 * 29/09/2024
 * Exercici 19  .
 *  19. Implementa un algorisme que donats dos nombres enters introduïts per teclat (num1, num2), retornar els seus valors intercanviats. Important! Les variables han d’emmagatzemar aquests valors intercanviats.
 * Entrada d’exemple
 *       3 4
 * Sortida d’exemple
 *       4 3
 *
 */

namespace TestActivitats
{
    public class SwitchNumbers
    {
        static void Main(string[] args)
        {
           
            //constants
            const string WRITE_NUMBERS = "Introdueix dos números enters: ";

            //variables
            int num1, num2, aux;

            
            Console.WriteLine(WRITE_NUMBERS);
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            
            aux = num1;
            num1 = num2;
            num2 = aux;

            //Sortida de dades
            Console.WriteLine(num1 + " " + num2);
        }
    }
}