﻿using System;

/*
 * Author: Manel Arbiol Calpe
 * T1. Activits. Introducció a la Programació
 * 1/10/2024
 * Exercici 11  .
 * 11. Implementa el pseudocodi d’un algorisme que informi a l’usuari 
 * si el valor que ha introduït per teclat és un número natural o no.
 */



namespace PrimerTemaActivitats
{
    public class IsNatural
    {
        static void Main()
        {
            const string MSG_ENTER_NUMBER = "Introdueix un número: ";
            const string MSG_ISNATURAL = "El número es natural.";
            const string MSG_NONATURAL = "El número no és natural";
            const string MSG_ERROR = "Error: Introdueix un número vàlid.";
            const int NUM_NATURAL = 1;


            try
            {
                double num;

                Console.WriteLine(MSG_ENTER_NUMBER);
                num = Convert.ToDouble(Console.ReadLine());

                if (num >= NUM_NATURAL && num % 1 == 0)
                {
                    Console.WriteLine(MSG_ISNATURAL);
                }
                else
                {
                    Console.WriteLine(MSG_NONATURAL);
                }
            }
            catch (Exception)
            {
                Console.WriteLine(MSG_ERROR);
            }

        }
    }
}