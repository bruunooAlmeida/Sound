﻿using System;

namespace MeuProjeto
{
    
    public class Utils
    {
        
        static int numradon;
        public static void exibeMenu()
        {
            Random random = new Random();
            numradon = random.Next(0, 100);
            Console.WriteLine(@"
                                ░█████╗░██████╗░██╗██╗░░░██╗██╗███╗░░██╗██╗░░██╗███████╗  ░█████╗░
                                ██╔══██╗██╔══██╗██║██║░░░██║██║████╗░██║██║░░██║██╔════╝  ██╔══██╗
                                ███████║██║░░██║██║╚██╗░██╔╝██║██╔██╗██║███████║█████╗░░  ██║░░██║
                                ██╔══██║██║░░██║██║░╚████╔╝░██║██║╚████║██╔══██║██╔══╝░░  ██║░░██║
                                ██║░░██║██████╔╝██║░░╚██╔╝░░██║██║░╚███║██║░░██║███████╗  ╚█████╔╝
                                ╚═╝░░╚═╝╚═════╝░╚═╝░░░╚═╝░░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚══════╝  ░╚════╝░

                                ███╗░░██╗██╗░░░██╗███╗░░░███╗███████╗██████╗░░█████╗░
                                ████╗░██║██║░░░██║████╗░████║██╔════╝██╔══██╗██╔══██╗
                                ██╔██╗██║██║░░░██║██╔████╔██║█████╗░░██████╔╝██║░░██║
                                ██║╚████║██║░░░██║██║╚██╔╝██║██╔══╝░░██╔══██╗██║░░██║
                                ██║░╚███║╚██████╔╝██║░╚═╝░██║███████╗██║░░██║╚█████╔╝
                                ╚═╝░░╚══╝░╚═════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░");
            Console.Clear();
            
            bool acertou = false;
            Console.WriteLine(numradon);
            do
            {            
                Console.WriteLine("Digite um Numero ");
                int palpite = int.Parse(Console.ReadLine());

                if (palpite == numradon)
                {
                    acertou = true;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine(@"
██████╗░░█████╗░██████╗░░█████╗░██████╗░███████╗███╗░░██╗░██████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝████╗░██║██╔════╝
██████╔╝███████║██████╔╝███████║██████╦╝█████╗░░██╔██╗██║╚█████╗░
██╔═══╝░██╔══██║██╔══██╗██╔══██║██╔══██╗██╔══╝░░██║╚████║░╚═══██╗
██║░░░░░██║░░██║██║░░██║██║░░██║██████╦╝███████╗██║░╚███║██████╔╝
╚═╝░░░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═════╝░╚══════╝╚═╝░░╚══╝╚═════╝░

██████╗░███████╗░██████╗░█████╗░███████╗██╗░█████╗░
██╔══██╗██╔════╝██╔════╝██╔══██╗██╔════╝██║██╔══██╗
██║░░██║█████╗░░╚█████╗░███████║█████╗░░██║██║░░██║
██║░░██║██╔══╝░░░╚═══██╗██╔══██║██╔══╝░░██║██║░░██║
██████╔╝███████╗██████╔╝██║░░██║██║░░░░░██║╚█████╔╝
╚═════╝░╚══════╝╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝░╚════╝░

██████╗░███████╗░██████╗░█████╗░██╗░░░░░██╗░░░██╗██╗██████╗░░█████╗░
██╔══██╗██╔════╝██╔════╝██╔══██╗██║░░░░░██║░░░██║██║██╔══██╗██╔══██╗
██████╔╝█████╗░░╚█████╗░██║░░██║██║░░░░░╚██╗░██╔╝██║██║░░██║██║░░██║
██╔══██╗██╔══╝░░░╚═══██╗██║░░██║██║░░░░░░╚████╔╝░██║██║░░██║██║░░██║
██║░░██║███████╗██████╔╝╚█████╔╝███████╗░░╚██╔╝░░██║██████╔╝╚█████╔╝
╚═╝░░╚═╝╚══════╝╚═════╝░░╚════╝░╚══════╝░░░╚═╝░░░╚═╝╚═════╝░░╚════╝░");

                    Console.ReadLine();
                    Console.Clear();
                    break;
                }

                if (numradon < palpite )
                {
                    Console.WriteLine("Valor informado é Valor é menor");
                }
                else Console.WriteLine("Valor informado é Valor é Maior");

            } while (!acertou);
        }
    }
}
