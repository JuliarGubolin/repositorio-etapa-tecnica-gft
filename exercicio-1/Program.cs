using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioColaborador=0.0, aumento=0.0, novoSalarioColaborador=0.0, valorDoAumento=0.0;
            Console.WriteLine("Digite seu salário atual: ");
            salarioColaborador = double.Parse(Console.ReadLine());

            if(salarioColaborador <= 280.00){
                aumento = 0.2;
            }else if(salarioColaborador > 280.00 && salarioColaborador <= 700.00){
                aumento = 0.15;
            }else if(salarioColaborador > 700.00 && salarioColaborador <= 1500.00){
                aumento = 0.1;
            }else{
                aumento = 0.05;
            }
            valorDoAumento = salarioColaborador*aumento;
            novoSalarioColaborador = (valorDoAumento+salarioColaborador);
            Console.WriteLine("Informações:");
            Console.WriteLine($"Salário antes do reajuste: {salarioColaborador}.");
            Console.WriteLine($"Percentual de aumento: {aumento*100}%.");
            Console.WriteLine($"Valor do aumento: {valorDoAumento}.");
            Console.WriteLine($"Salário após o reajuste: {novoSalarioColaborador}.");
        }
    }
}