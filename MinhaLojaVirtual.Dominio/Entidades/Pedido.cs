using MinhaLojaVirtual.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinhaLojaVirtual.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public string NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }

        public FormaPagamento FormaPagamento { get; set; }

        // pedido deve ter pelo menos UM item de pedido ou muitos itens de pedidos
        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagemDeValidacao();

            if (! ItensPedido.Any())

                AdicionarMensagem("Crítica - Pedido não pode ficar sem Item de Pedido");
            if (string.IsNullOrEmpty(CEP))

                AdicionarMensagem("Crítica - Capmpo CEP não pode estar vazio");
            
        }
    }
}
