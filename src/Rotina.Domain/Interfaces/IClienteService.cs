using Rotina.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
