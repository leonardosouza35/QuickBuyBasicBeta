using System.Collections.Generic;

namespace QuickBuyBasicBeta.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        public virtual ICollection<Venda> Vendas { get; private set; }

        public void AdicionarVenda(Venda venda)
        {
            if(venda != null)
            {
                // Adicionar mensagem de validação em algum lista contendo criticas e erros de negocio                
            }

            if(venda.UsuarioId != 0)
            {
                // Adicionar mensagem de validação em algum lista contendo criticas e erros de negocio                
            }

            // Esta tudo bem... então eu posso adicionar a instancia de venda na lista Vendas
            Vendas.Add(venda);
        }

    }
}
