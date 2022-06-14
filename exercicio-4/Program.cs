using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, ano;

            Console.Write($"Digite um dia: ");
            dia = int.Parse(Console.ReadLine());
            Console.Write($"Digite um mes: ");
            mes = int.Parse(Console.ReadLine());
            Console.Write($"Digite um ano: ");
            ano = int.Parse(Console.ReadLine());
            
            if((mes < 1 || mes > 12) || (dia > 31 || dia < 1) || (ano > 2000)){
                Console.Write($"Data inválida, pois ");
                if(dia > 31 || dia < 1){
                Console.Write($"o dia {dia} não está entre os valores 1 e 31 ");
                }if(mes < 1 || mes > 12){
                    Console.Write($"o mês {mes} não está entre os valores 1 e 12 ");
                }if(ano > 2000){
                    Console.Write($"o ano {ano} excede o ano atual 2000.");
                }
            }else{
                Console.Write($"Data válida.");
            }
        }
    }
}
