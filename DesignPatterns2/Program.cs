using DesignPatterns2.Cap8;
using System;
using System.IO;
using System.Xml.Serialization;

namespace DesignPatterns2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = "Lucas";
            cliente.Endereco = "Rua das Couves";
            cliente.DataDeNascimento = DateTime.Now;

            string xml = new GeradorDeXml().GeraXML(cliente);

            Console.WriteLine(xml);
        }
    }
}