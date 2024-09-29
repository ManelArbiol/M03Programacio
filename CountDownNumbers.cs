using System;
/*
 * Author: Manel Arbiol Calpe
 * T1. Activits. Introducció a la Programació
 * 29/09/2024
 * Exercici 20  .
 *  20. Implementa un algorisme que demani a l'usuari que introdueixi un valor enter (N) i es mostri per pantalla un compte enrere de N fins a 1.
 *
 *  Entrada d’exemple
 *     5
 *   Sortida d’exemple
 *     5 4 3 2 1
 */

namespace TestActivitats
{
    public class CountDownNumbers
    {
        public static void Main(string[] args)
        {
            //constants
            
            string WRITE_NUMBER = "Introdueix un número enter: ";


            Console.WriteLine(WRITE_NUMBER);
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = number; i > 0; i--)
            {
                Console.Write(i + " ");
            }
        }
    }   
    
}