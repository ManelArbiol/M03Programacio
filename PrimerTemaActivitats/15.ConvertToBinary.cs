using System;
using System.Net.Security;
using System.Reflection.Metadata.Ecma335;

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


        static void Main(string[] args)
        {

            const int MAX_DIGITS = 7;
            const string MSG_ENTER_NUMBER = "Introdueix un número natural de fins a 7 xifres: ";
            const string MSG_INVALID_NUMBER = "Número no vàlid. Introdueix un número de fins a 7 xifres.";
            const string MSG_BINARY_VALUE = "El valor en binari és: ";
            const string MSG_ERROR = "Error. Has d'introduïr un número.";


            int num = 0, rem, xDigits = 0;


            string bin = "";

            // Bucle para validar les xifres del número introduït
            do
            {
                xDigits = 0;
                try
                {
                    Console.Write(MSG_ENTER_NUMBER);
                    num = Convert.ToInt32(Console.ReadLine());
                    int tempNum = num;
                    while (tempNum > 0)
                    {
                        tempNum = tempNum / 10;
                        xDigits++;
                    }


                    if (xDigits > MAX_DIGITS)
                    {
                        Console.WriteLine(MSG_INVALID_NUMBER);
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine(MSG_ERROR);
                    bool continueCode;
                }
            } while (xDigits > MAX_DIGITS);

            // Algoritme per pasar de decimal a binari
            if ()
                while (num != 0)
                {
                    rem = num % 2;
                    num = num / 2;
                    bin = bin + rem;
                }
            Console.WriteLine(MSG_BINARY_VALUE + bin);
        }
    }
}
