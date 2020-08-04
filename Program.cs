using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APS
{
    class Program
    {
        static void Main(string[] args)

        {
            int opcao;
            string msg = "";
            do
            {
                string palavra;
                string palavra_c;
                string crpt = "";
                string crpt_c = "";


                Console.WriteLine("\n");
                Console.WriteLine("Digite a opção desejada");
                Console.WriteLine("Opção 1 = Criptografar uma mensagem");
                Console.WriteLine("Opção 2 = Descriptografar uma mensagem");
                if (msg != "")
                {
                    Console.WriteLine("Opção 3 = Descriptografar a última mensagem");
                }
                Console.WriteLine("Opção 0 = Sair do programa");
                Console.WriteLine("");

                Console.Write("Opção: ");
                opcao = int.Parse(Console.ReadLine());


                switch (opcao)
                {
                    //criptografar
                    case 1:
                        Console.WriteLine("\nDigite a mensagem à ser criptografada:");
                        palavra = Console.ReadLine();
                       
                        for (int i = 0; i < palavra.Length; i++)
                        {
                            //codigo ASCII da palavra
                            int ASCII = (int)palavra[i];

                            //ASCII adicionado com o pulo
                            int ASCII_F = ASCII + 5;

                            crpt += Char.ConvertFromUtf32(ASCII_F);
                        }

                        Console.WriteLine("\nResultado");
                        Console.WriteLine(crpt);

                        Console.Write("\nPressione qualquer tecla para continuar");
                        Console.ReadKey();

                        break;

                    //descriptografar
                    case 2:
                        Console.WriteLine("\nDigite a frase para ser descriptografada:");
                        {
                            palavra_c = Console.ReadLine();

                            for (int i = 0; i < palavra_c.Length; i++)
                            {
                                //codigo ASCII da palavra
                                int ASCII = (int)palavra_c[i];

                                //ASCII adicionado com o pulo
                                int ASCII_F = ASCII - 5;

                                crpt_c += Char.ConvertFromUtf32(ASCII_F);
                            }

                            Console.WriteLine("\nResultado");
                            Console.WriteLine(crpt_c);

                            Console.Write("\nPressione qualquer tecla para continuar");
                            Console.ReadKey();

                            break;
                        }
                        case 3:
                        {
                            if (msg != "")
                            {
                                palavra = msg;
                                for (int i = 0; i < palavra.Length; i++)
                                {
                                    //codigo ASCII da palavra
                                    int ASCII = (int)palavra[i];

                                    //ASCII adicionado com o pulo
                                    int ASCII_F = ASCII - 5;

                                    crpt += Char.ConvertFromUtf32(ASCII_F);
                                }

                                Console.WriteLine("\nResultado");
                                Console.WriteLine(crpt);
 
                            }
                            else
                            {
                                Console.WriteLine("\n Nenhuma mensagem digitada");
                            }

                            Console.Write("\nPressione qualquer tecla para continuar");
                            Console.ReadKey();
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Digite uma das opções por favor.");

                            break;
                        }
                }
                msg = crpt;
            } while (opcao != 0);

        }

    }
}