using System;
using System.Collections.Generic;

namespace QuickBuyBasicBeta.Dominio.Entidades
{
    public class Venda : Entidade
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public int UsuarioId { get; set; }

        public IEnumerable<ItemVenda> ItensVenda { get; set; }

        public bool EhValido()
        {
            if (UsuarioId == 0)
                return false;

            return true;
        }
    }
}
