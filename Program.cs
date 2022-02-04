/*Tres interacoes do laço externo, e cinco interacao do laço interno*/
using System;

namespace exemploPraticoInstrucaoWhileAlinhada
{
    class Program
    {
        static void Main(string[] args)
        {   
            int contadorExterno = 0;
            int contadorInterno = 0;

            while(contadorExterno < 3)
            {   
                Console.WriteLine($"\n##### Laço externo: {contadorExterno} #####");
                
                while (contadorInterno < 5)
                {
                    Console.WriteLine($"Laço interno: {contadorInterno}");
                    contadorInterno = contadorInterno + 1;
                }

                contadorExterno = contadorExterno + 1;
                contadorInterno = 0;
            }
        }
    }
}
