using System;

namespace sistema_de_produtos
{
    class Program
    {
        static int opcoes;
        static int sair = 0;
        static string[] nome = new string[10];
        static float[] preco = new float[10];
        static bool[] promocaoItem = new bool[10];
        static int c = 0;
        static string promocao;
        
        static void Main(string[] args)
        {
            do
            {
                opcoes = MostrarMenuComRetorno();

                if (opcoes == 1)
                {
                    MenuOpcaoum();
                }
                else if (opcoes == 2)
                {
                    MenuOpcaodois();
                }
                else if (opcoes == 0)
                {
                    Console.WriteLine("Você irá sair");
                }
                else
                {
                    Console.WriteLine("Inválido");
                }




            } while (sair != opcoes);
        }

        static int MostrarMenuComRetorno()
        {
            Console.WriteLine(@"
                
                |------------------------------------------|
                |     Selecione uma das opções abaixo:     |
                |------------------------------------------|
                |                                          |
                |           1 : Cadastrar Produto          |
                |           2 : Listar Produto             |
                |           0 : Sair                       |
                |                                          |
                |------------------------------------------|
                                    ");
            int opcoesMenu = int.Parse(Console.ReadLine().ToLower());
            return opcoesMenu;
        }

        static void MenuOpcaoum()
        {

            Console.WriteLine("Cadastro do Produto!");

            string respostaSair = "n";

            do
            {
                if (c <= 10)
                {
                    Console.WriteLine("Qual o nome produto a ser cadastrado: ");
                    nome[c] = Console.ReadLine();

                    Console.WriteLine("Qual o preço do produto: ");
                    preco[c] = float.Parse(Console.ReadLine());

                    Console.WriteLine("Esse produto está em promoção? (S/N)");
                    promocao = Console.ReadLine().ToLower();

                    if (promocao == "s")
                    {
                        promocaoItem[c] = true;
                    }
                    else
                    {
                        promocaoItem[c] = false;
                    }

                    Console.WriteLine("Deseja cadastrar mais produto? (S/N)");
                    Console.WriteLine($"Você possui {(c + 1)} produtos cadastrados até o momento (Máximo de 10!)!");
                    respostaSair = Console.ReadLine().ToLower();

                    c++;
                }
                else
                {
                    Console.WriteLine("Você já atingiu o máximo de produtos cadastrados!");
                }

            } while (respostaSair == "s");

        }

        static void MenuOpcaodois()
        {
            Console.WriteLine("Você irá Listar Produtos!");

            for (var i = 0; i < c; i++)
            {
                Console.WriteLine($"Nome = {nome[i]}  -  Preço = $ {preco[i]}  -  Está em promoção? = {promocaoItem[i]}",promocaoItem[i]? "Sim" : "Não");
            }
         
        }
    }
}
