using DesignPatterns2.Cap1;
using DesignPatterns2.Cap2;
using DesignPatterns2.Cap3;
using DesignPatterns2.Cap4;
using DesignPatterns2.Cap5;
using DesignPatterns2.Cap6;
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
            IMensagem mensagem = new MensagemAdministrativa("Lucas");
            IEnviador enviador = new EnviaPorSMS();
            
            mensagem.Enviador = enviador;
            
            mensagem.Envia();

            enviador = new EnviaPorEmail();

            mensagem.Enviador = enviador;

            mensagem.Envia();

            mensagem = new MensagemCliente("Lucas");
            enviador = new EnviaPorSMS();

            mensagem.Enviador = enviador;

            mensagem.Envia();

            enviador = new EnviaPorEmail();

            mensagem.Enviador = enviador;

            mensagem.Envia();
        }
    }
}