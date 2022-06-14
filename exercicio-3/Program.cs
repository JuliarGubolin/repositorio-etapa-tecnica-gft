using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanho=5, idade=0, qtdPessoas=0, qtdPessoas1=0, i=0;
            double altura=0.0, peso=0.0, somaIdades=0.0, mediaIdades=0.0;

            for (i = 0; i < tamanho; i++)
            {
                Console.WriteLine($"---Pessoa {i+1}---");
                Console.Write($"Digite a altura da pessoa {i+1}: ");
                altura = double.Parse(Console.ReadLine());
                Console.Write($"Digite o peso da pessoa {i+1}: ");
                peso = double.Parse(Console.ReadLine());
                Console.Write($"Digite a idade da pessoa {i+1}: ");
                idade= int.Parse(Console.ReadLine());
                somaIdades = idade + somaIdades;
                if(peso > 90.0 && altura < 1.50){
                    qtdPessoas++;
                }
                if(altura > 1.90){
                    if(idade >= 10 && idade<=30){
                        qtdPessoas1++;
                    }
                }
            }

            mediaIdades = somaIdades/tamanho;
            double qtdPessoasPercentagem = Convert.ToDouble(qtdPessoas1);
            double tamanhoAux = Convert.ToDouble(tamanho);
            double resultado = qtdPessoas1/tamanho;
            Console.WriteLine($"A média das idades é: {mediaIdades.ToString("N2")}.");
            Console.WriteLine($"A quantidade de pessoas com peso superior a 90 quilos e altura inferior a 1.50 é: {qtdPessoas}.");
            Console.WriteLine($"A porcentagem de pessoas com idade entre 10 e 30 anos entre as pessoas que medem mais de 1.90 é: {(resultado)}.");
        }
    }
}
