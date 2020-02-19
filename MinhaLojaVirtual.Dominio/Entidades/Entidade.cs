using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinhaLojaVirtual.Dominio.Entidades
{
   public abstract class Entidade
    {
        public List<string> _mensagensValidacao { get; set; }
        private List<string> mensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        protected void LimparMensagemDeValidacao()
        {
            mensagemValidacao.Clear();
        }

        protected void AdicionarMensagem( string m)
        {
            mensagemValidacao.Add(m);
        }

        public abstract void Validate();
        protected bool EhValido
        {
            get { return ! mensagemValidacao.Any(); }
        }

    }
}
