using Rotina.Domain.Entities;
using System;

namespace Rotina.Domain.Interfaces
{
    public interface IClienteService : IDisposable
    {
        Cliente Adicionar(Cliente cliente);
        Cliente Alterar(Cliente cliente);
        void Remover(Cliente cliente);
        Cliente ObterPorId(int id);
        void Dispose();
    }
}
