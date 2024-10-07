using System;

/*
 * Author: Manel Arbiol Calpe
 * T1. Activits. Introducció a la Programació
 * 3/10/2024
 * Exercici 13  .
 * 13.  Implementa el pseudocodi d’un programa que demani un nombre enter per teclat que estigui dins de l’interval (2, 30). L’usuari disposarà de 3 intents per a indicar un nombre de l’interval. 
 * En cas contrari, el programa indicarà que ha perdut i finalitzarà.
 */



namespace PrimerTemaActivitats
{
    public class IntervalRangeWithTrys
    {
        static void Main()

        //constants
        {
            const int MAX_RANGE = 30;
            const int MIN_RANGE = 2;
            const int MAX_TRIES = 3;
            const string ENTER_NUM_TXT = "Introdueix un número entre 3 i 30: ";
            const string CORRECT_NUM_TXT = "El número introduït és correcte.";
            const string INCORRECT_NUM_TXT = "El número introduït no està dins del interval.";
            const string LOST_TRIES_TXT = "Has esgotat tots els intents.";
            const string TRYS_LEFT_TXT = "$Et queden {0} intents.";
            const string WIN_TXT = "Has guanyat!";

            //variables

            int num, numTryes = 0;


            //code

            do
            {
                numTryes++;
                Console.Write(${ ENTER_NUM_TXT + }
                T
                num = Convert.ToInt32(Console.ReadLine());
                if (num >= MIN_RANGE && num <= MAX_RANGE)
                {
                    Console.WriteLine(CORRECT_NUM_TXT);
                    Console.WriteLine(WIN_TXT);
                }
                else
                {
                    Console.WriteLine(INCORRECT_NUM_TXT);
                }
            } while ((num < MIN_RANGE || num > MAX_RANGE) && numTryes < MAX_TRIES);
            Console.ReadLine();
            if (numTryes == MAX_TRIES)
            {
                Console.WriteLine(LOST_TRIES_TXT);
            }
        }
    }
}