using System.Collections.Generic;

namespace QuickBuyBasicBeta.Dominio.Entidades
{
    public abstract class Entidade
    {
        private List<string> _mensagemValidacao;
        public List<string> MensagemValidacao
        {
            get { return _mensagemValidacao ?? (_mensagemValidacao = new List<string>()); }
        }

        void LimparMensagensValidacao ()
        {
            MensagemValidacao.Clear();
        }
        void AdicionarMensagem(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }

    }
}
