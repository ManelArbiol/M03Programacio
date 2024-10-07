using System;


/*
 * Author: Manel Arbiol Calpe
 * T1. Activits. Introducció a la Programació
 * 29/09/2024
 * Exercici 15.
 * 15. Implementa el pseudocodi d’un algorisme que, donat un nombre natural 
 * introduït per teclat (de 7 xifres com a màxim), retorni el seu valor en binari.
 */

namespace PrimerTemaActivitats
{
    public class ConvertToBinary
    {
        static void Main()
        {
            const int MAX_DIGITS = 7;
            const string MSG_ENTER_NUMBER = "Introdueix un número natural de fins a 7 xifres: ";
            const string MSG_INVALID_NUMBER = "Número no vàlid. Introdueix un número de fins a 7 xifres.";
            const string MSG_BINARY_VALUE = "El valor en binari és: ";
            const string MSG_ERROR = "Error. Has d'introduïr un número.";

            long num, rem, xDigits, bin = 0, shift = 1;
            

            try
            {
                // Bucle para validar les xifres del número introduït
                do
                {
                    xDigits = 0;
                    Console.Write(MSG_ENTER_NUMBER);
                    num = Convert.ToInt64(Console.ReadLine());
                    long tempNum = num;
                    while (tempNum > 0)
                    {
                        tempNum /= 10;
                        xDigits++;
                    }

                    if (xDigits > MAX_DIGITS)
                    {
                        Console.WriteLine(MSG_INVALID_NUMBER);
                    }
                } while (xDigits > MAX_DIGITS);

                // Algoritme per pasar de decimal a binari
                while (num != 0)
                {
                    rem = num % 2;
                    num /= 2;
                    bin += rem * shift;
                    shift *= 10;
                }

                Console.WriteLine(MSG_BINARY_VALUE + bin);
            }
            catch (Exception)
            {
                Console.WriteLine(MSG_ERROR);
            }
        }
    }
}
