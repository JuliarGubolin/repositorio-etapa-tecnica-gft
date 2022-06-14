using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao=0;
            double nota1, nota2, nota3, mediaA, mediaP;
            double peso1, peso2, peso3;

            do{
                Console.WriteLine("---------------------");
                Console.WriteLine("Selecione uma das opções abaixo:");
                Console.WriteLine("1 - Média aritmética");
                Console.WriteLine("2 - Média ponderada");
                Console.WriteLine("3 - Sair");
                Console.WriteLine("---------------------");
                Console.Write("-> ");
                opcao = int.Parse(Console.ReadLine());
                switch(opcao){
                    case 1:
                        Console.WriteLine("Média aritmética");
                        Console.Write("Digite a nota 1: ");
                        nota1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite a nota 2: ");
                        nota2 = double.Parse(Console.ReadLine());
                        mediaA = (nota1+nota2)/2;
                        Console.Write($"A média aritmética de {nota1} e {nota2} é: {mediaA}.\n");
                        break;
                    case 2:
                        Console.WriteLine("Média Ponderada");
                        Console.Write("Digite a nota 1: ");
                        nota1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o peso da nota 1: ");
                        peso1 = double.Parse(Console.ReadLine());
                        Console.Write("Digite a nota 2:  ");
                        nota2 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o peso da nota 2: ");
                        peso2 = double.Parse(Console.ReadLine());
                        Console.Write("Digite a nota 3: ");
                        nota3 = double.Parse(Console.ReadLine());
                        Console.Write("Digite o peso da nota 3: ");
                        peso3 = double.Parse(Console.ReadLine());
                        mediaP = ((nota1*peso1)+(nota2*peso2)+(nota3*peso3))/(peso1+peso2+peso3);
                        Console.Write($"A média ponderada de {nota1}, {nota2} e {nota3} é: {mediaP}.\n");
                        break;
                    case 3:
                        Console.WriteLine("Programa encerrado.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Leia novamente o Menu.");
                        break;
                }
            }while(opcao != 3);

        }
    }
}