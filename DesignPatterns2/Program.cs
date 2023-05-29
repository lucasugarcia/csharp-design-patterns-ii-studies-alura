using DesignPatterns2.Cap1;
using DesignPatterns2.Cap2;
using DesignPatterns2.Cap3;
using DesignPatterns2.Cap4;
using DesignPatterns2.Cap5;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var esquerda = new Soma(new Numero(1), new Numero(10));
            var direita = new Subtracao(new Numero(20), new Numero(10));

            var soma = new Soma(esquerda, direita);

            Console.WriteLine(soma.Avalia());

            Impressora impressora = new Impressora();
            soma.Aceita(impressora);
        }
    }
}