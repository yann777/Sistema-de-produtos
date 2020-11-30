using System;

namespace Sistema_de_produtos
{
    class Program
    {
        static void Main(string[] args)
        {
             string[] produtos = new string[3];
            float[] preco = new float[3];
            bool[] promocao = new bool[1];
            int contador = 0;
            string answer;
            int choice;

            Console.WriteLine("---------------------------------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("------{Sistema de Produtos}------");
            Console.ResetColor();
            Console.WriteLine("---------------------------------");

            do{
                Console.WriteLine("---Menu inicial---");
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("[1] - Cadastrar produtos");
                Console.WriteLine("[2] - Listar produtos");
                Console.WriteLine("[0] - Sair");
                choice = int.Parse(Console.ReadLine());

            switch(choice){
                   case 1:

                        do{
                            if(contador < produtos.Length){
                                Console.Write($"Digite o nome do {contador+1}º produto: ");
                                produtos[contador] = Console.ReadLine();

                                Console.Write($"Digite o Preço do {contador+1}º produto: ");
                                preco[contador] = int.Parse(Console.ReadLine());
                                contador++;
                            } 
                            else {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Limite excedido.");
                                Console.ResetColor();
                            }

                            System.Console.WriteLine("Gostaria de adicionar mais um produto?");
                            System.Console.WriteLine("[S] - Sim");
                            System.Console.WriteLine("[N] - Não");
                            answer = Console.ReadLine();
                        } while (answer.ToUpper() == "S");
                        break;
                    case 2:
    
                        for(int i = 0; i < produtos.Length; i++){
                            System.Console.WriteLine("------------------------");
                            Console.WriteLine($"Nome do {i+1}º produto: {produtos[i]}. Preço: R${preco[i]} {promocao[i]} ");
                        }
                        break;
                    case 0:

                    break;
                }
            } while (choice != 0);

            int validacaoPromocao = 0;

            if(validacaoPromocao >= 10 ){
                validacaoPromocao = AnalisarPromocao(promocao[i]);
            }
            else{
                validacaoPromocao = AnalisarPromocao(promocao[i]);
            }
         
         bool AnalisarPromocao (bool promocao){
                if(promocao == true ){
                    Console.WriteLine("Está em promoção");
                    return true;
                } 
                else {
                    Console.WriteLine("Não está em promoção");
                    return false;
                }

            }
        }
    }
}
