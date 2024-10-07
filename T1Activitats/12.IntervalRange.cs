using System;

/*
 * Author: Manel Arbiol Calpe
 * T1. Activits. Introducció a la Programació
 * 3/10/2024
 * Exercici 12  .
 * 12. Implementa el pseudocodi d’un algorisme que informi a l’usuari si el valor 
 * que ha introduït per teclat és dins de l’interval (5, 50).
 */



namespace T1Activitats
{
    public class IntervalRange
    {
        static void Main()

        //constants
        {
            const int MAX_RANGE = 50;
            const int MIN_RANGE = 5;
            const string ENTER_NUM_TXT = "Introdueix un número entre 5 i 50: ";
            const string CORRECT_NUM_TXT = "El número introduït és correcte.";
            const string INCORRECT_NUM_TXT = "El número introduït no està dins del interval.";

            //variables

            int num;

            Console.WriteLine(ENTER_NUM_TXT);
            num = Convert.ToInt32(Console.ReadLine());

            if (num >= MIN_RANGE && num <= MAX_RANGE)
            {
                Console.WriteLine(CORRECT_NUM_TXT);
            }
            else
            {
                Console.WriteLine(INCORRECT_NUM_TXT);
            }
        }
    }
}