using System;

namespace DarkSoulsBuilds

{
    public class Controller
    {
        
        public void comeco(){

            string choice;

            Console.WriteLine("Bem vindos ao programa de builds de Dark Souls!!\n");

            while (true)
            {               

            
            Console.WriteLine("Digite 1 para adicionar uma build de personagem, 2 para Checar as builds, 3 para buscar build por alguma chave, 4 para deletar build, 5 para informações e outra coisa para sair.\n");

            Console.WriteLine("Escolha: ");

            choice = Console.ReadLine();

            Console.Clear();

            switch (choice)
            {
                case '1':

                break;

                default:

                Console.WriteLine("Deseja mesmo fechar o programa?\n");

                Console.WriteLine("Escolha: ");    

                string exit, tent;

                exit = Console.ReadLine();
                exit = Convert.ToChar(tent);

                Console.Clear();

                if (exit == 's' || exit == 'S')
                {
                    Console.WriteLine("Obrigado por utilizar o programa!\n");
                    break;
                }
                else
                {
                    continue;
                }
            }

            }
        }

    }
}