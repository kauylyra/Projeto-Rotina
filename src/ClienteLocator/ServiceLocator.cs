using Rotina.Application;
using Rotina.Application.Interface;
using Rotina.Domain.Interfaces;
using Rotina.Domain.Services;
using Rotina.Infra;
using Rotina.Infra.Context;
using SimpleInjector;

namespace ClienteLocator
{
    public class ServiceLocator
    {
        public static void RegisterServices(Container container)
        {
            container.Register<IClienteApplication, ClienteApplication>(Lifestyle.Singleton);
            container.Register<IClienteService, ClienteService>(Lifestyle.Singleton);
            container.Register<IRepositoryBase, RepositoryBase>(Lifestyle.Singleton);
            container.Register<ClienteContext>(Lifestyle.Singleton);
        }
    }
}
