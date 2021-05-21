using Rotina.Application.Interface;
using Rotina.Domain.Entities;
using Rotina.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotina.Application
{
    public class ClienteApplication : IClienteApplication
    {
        private readonly IClienteService _clienteService;
        public ClienteApplication(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }
        public Cliente Adicionar(Cliente cliente)
        {
            return _clienteService.Adicionar(cliente);
        }

        public Cliente Alterar(Cliente cliente)
        {
            return _clienteService.Alterar(cliente);
        }

        public Cliente ObterPorId(int id)
        {

            return _clienteService.ObterPorId(id);
        }

        public void Remover(Cliente cliente)
        {
            _clienteService.Remover(cliente);
        }

        public void Dispose()
        {
            _clienteService.Dispose();
        }

    }
}
