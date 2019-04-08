using System;
using System.Collections.Generic;

namespace QuickBuyBasicBeta.Dominio.Contratos
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity: class
    {
        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();
        void Adicionar(TEntity entity);
        void Atualizar(TEntity entity);
        void Remover(TEntity entity);

    }
}
