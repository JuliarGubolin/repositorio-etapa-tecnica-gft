using System;
using exercicio_1.Models;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.CPF = "123.456.789-10";
            p.nome = "Julia Gubolin";
            p.idade = 20;

            Professor prof = new Professor();
            prof.CPF = "2345";
        }
    }
}