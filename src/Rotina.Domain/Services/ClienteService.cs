using Rotina.Domain.Entities;
using Rotina.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotina.Domain.Services
{
    public class ClienteService : IClienteService
    {
        private readonly IRepositoryBase _repositoryBase;
        public ClienteService(IRepositoryBase repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }
        public Cliente Adicionar(Cliente cliente)
        {
            return _repositoryBase.Adicionar(cliente);
        }

        public Cliente Alterar(Cliente cliente)
        {
            return _repositoryBase.Alterar(cliente);
        }

        public Cliente ObterPorId(int id)
        {
            return _repositoryBase.ObterPorId(id);
        }

        public void Remover(Cliente cliente)
        {
            _repositoryBase.Remover(cliente);
        }

        public void Dispose()
        {
            _repositoryBase.Dispose();
        }
    }
}
