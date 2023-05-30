﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns2.Cap6
{
    class MensagemAdministrativa : IMensagem
    {
        public IEnviador Enviador { get; set; }
        private string nome;

        public MensagemAdministrativa(string nome)
        {
            this.nome = nome;
        }

        public void Envia()
        {
            this.Enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Enviando mensagem para o administrador {0}", nome);
        }
    }
}
