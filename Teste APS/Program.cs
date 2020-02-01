using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_APS
{
    class Program
    {
        static void Main(string[] args)
        {

            string palavra, encrypt = "";

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetWindowSize(66, 9);
            Console.Write("\t\t|---------------------------------|\n");
            Console.Write("\t\t| 0 - Sair                        |\n");
            Console.Write("\t\t| 1 - Criptografar um mensagem    |\n");
            Console.Write("\t\t| 2 - Decriptografar uma mensagem |\n");
            Console.Write("\t\t|---------------------------------|\n");
            Console.Write("\t\t|Escolha a opçao:\t\t  |\n");
            Console.WriteLine("\t\t|---------------------------------|\n");

            Console.CursorTop = 5;
            Console.CursorLeft = 33;

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {

                //caso a opcao seja 1
                case 1: Console.Write("\nEntre com a mensagem para ser criptografada: ");
                    Console.CursorTop = 7;
                    Console.CursorLeft = 44;
                    //ToLower() transforma qualquer letra maiúscula em minúscula
                    palavra = Console.ReadLine().ToLower();

                    for (int i = 0; i < palavra.Length; i++)
                    {
                        //Devolve o codigo ASCII da letra
                        int ASCII = (int)palavra[i];

                        //Coloca a chave fixa adicionando 3 posições no numero da tabela ASCII
                        int ASCIIC = ASCII + 3;

                        //Concatena o texto e o coloca na variável
                        encrypt += Char.ConvertFromUtf32(ASCIIC);
                    }

                    Console.Write("A mensagem criptografada é: " + encrypt);

                    Console.ReadKey();

                    //representa o final do case 1
                    break;

                //caso a opcao escolhida for 2
                case 2: Console.Write("\nEntre com a mensagem para ser decriptografada:");

                    palavra = Console.ReadLine().ToLower();

                    for (int i = 0; i < palavra.Length; i++)
                    {

                        int ASCII = (int)palavra[i];

                        //Coloca a chave fixa retirando 3 posições no numero da tabela ASCII
                        int ASCIIC = ASCII - 3;

                        encrypt += Char.ConvertFromUtf32(ASCIIC);

                    }

                    Console.Write("A mensagem descriptografa é:"+encrypt);

                    Console.ReadKey();

                    break;

            }

        }

    }
}
 

