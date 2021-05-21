using Dapper;
using Rotina.Domain.Entities;
using Rotina.Domain.Interfaces;
using Rotina.Infra.Context;
using System;
using System.Data.Entity;
using System.Linq;

namespace Rotina.Infra
{
    public class RepositoryBase : IRepositoryBase
    {
        private readonly ClienteContext db;

        public RepositoryBase(ClienteContext context)
        {
            db = context;
        }
        public Cliente Adicionar(Cliente cliente)
        {
           var salvarCliente = db.Clientes.Add(cliente);
            db.SaveChanges();
            return salvarCliente;
        }

        public Cliente Alterar(Cliente cliente)
        {
            db.Entry(cliente).State = EntityState.Modified;
            db.SaveChanges();
            return cliente;
        }

        public Cliente ObterPorId(int id)
        {
            var dbConnection = db.Database.Connection;
            string SqlQuery = @"SELECT * FROM Cliente WHERE ID_Cliente = @ID_Cliente";
            return dbConnection.Query<Cliente>(SqlQuery, new { ID_Cliente = id }).FirstOrDefault();
        }

        public void Remover(Cliente cliente)
        {
            db.Clientes.Remove(cliente);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
