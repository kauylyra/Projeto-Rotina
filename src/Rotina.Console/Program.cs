using ClienteLocator;
using Rotina.Application.Interface;
using Rotina.Domain.Entities;
using SimpleInjector;
using System;

namespace Rotina
{
    class Program
    {
        private static readonly Container container;
        static Program()
        {
            container = new Container();
            ServiceLocator.RegisterServices(container);
            container.Verify();
        }
        static void Main(string[] args)
        {
            
            while(true)
            {
                try
                {
                    Console.WriteLine("Pressione ENTER para iniciar a execução do programa.");
                    var acionar = Console.ReadKey();
                    if (acionar.Key == ConsoleKey.Enter)
                    {
                        Console.WriteLine("Início da Execução" + DateTime.Now);
                        Console.WriteLine("------------------------------------");

                        Executar();
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("Fim da execução." + DateTime.Now);
                    }
                    else
                    {
                        Console.WriteLine("\nVocê não iniciou a execução." + "\n Fim.");
                    }
                }catch (Exception erro)
                {
                    Console.WriteLine(erro.InnerException.Message);
                }
                Console.ReadKey();
            }
        }
        static void Executar()
        {
            var app = container.GetInstance<IClienteApplication>();
            Cliente cliente = new Cliente()
            {
                Nome = "Kauy Lyra",
                Cidade = "São Paulo",
                Bairro = "Jardim das Rosas",
                Ativo = true
            };
            var cliente2 = new Cliente()
            {
                Nome = "teste",
                Cidade = "teste",
                Bairro = "teste",
                Ativo = false
            };
            app.Adicionar(cliente);
            app.Adicionar(cliente2);
            cliente2.Nome = "Alterado";
            app.Alterar(cliente2);
            app.Remover(cliente2);
            app.ObterPorId(cliente.ID_Cliente);
            Console.WriteLine("E-mail Enviado com sucesso para "+ cliente.Nome);
            Console.WriteLine("Dados do Cliente" +"\nID do Cliente: "+ cliente.ID_Cliente + "\nNome do Cliente: " +cliente.Nome + "\nCidade: " +cliente.Cidade + "\nBairro: " +cliente.Bairro + "\nCliente Está Ativo: " +cliente.Ativo);
        }
    }
}
