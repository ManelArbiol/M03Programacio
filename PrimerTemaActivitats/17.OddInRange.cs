using System;
/*
 * Author: Manel Arbiol Calpe
 * T1. Activits. Introducció a la Programació
 * 29/09/2024
 * Exercici 17  .
 * 17. Implementa un algorisme que mostri només els nombres no parells del següent interval [0, 100] (inclosos).
 *
 */

namespace PrimerTemaActivitats
{
    public class OddInRange
    {
        static void Main(string[] args)
        {

            //constantes
            const string NUMBER_ODD = "Els numeros no parells entre 0 i 100 són: ";


            Console.WriteLine(NUMBER_ODD);

            for (int i = 0; i <= 100; i++)
            {

                if (i % 2 != 0)
                {
                    //Utilitzo Console.Write i no Console.WriteLine perque
                    //vui que el ordre de surtida sigui en horizontal i no vertical, ja que Console.WriteLine
                    //imprimeix les dades a la consola i afegeix una nova línia al final.
                    //Això significa que si fas un altre Console.Write o Console.WriteLine després de Console.WriteLine,
                    //les noves dades s'imprimiran en una nova línia i no al costat.
                    Console.Write(i + " ");
                }
            }
        }
    }
}