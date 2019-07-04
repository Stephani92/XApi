

using System.Data.Entity;
using Unity;
using Unity.Lifetime;
using XApi.Domain.Interfaces.Repositories.Base;
using XApi.Domain.Services;
using XApi.Infra.Persistence.Repositories.Base;
using XApi.Infra.Persistence;
using prmToolkit.NotificationPattern;
using XApi.Infra.Persistence.Repositories;
using XApi.Domain.Interfaces.Repositories;
using XApi.Infra.Transactions;
using XApi.Domain.Interfaces.Services;

namespace XApi.IoC.Unity
{
    public static class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {

            container.RegisterType<DbContext, XApiContext >(new HierarchicalLifetimeManager());
            //UnitOfWork
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            container.RegisterType<INotifiable, Notifiable>(new HierarchicalLifetimeManager());

            //Serviço de Domain
            //container.RegisterType(typeof(IServiceBase<,>), typeof(ServiceBase<,>));

            container.RegisterType<IServPessoa, ServicePessoa>(new HierarchicalLifetimeManager());
           // container.RegisterType<IServiceJogo, ServiceJogo>(new HierarchicalLifetimeManager());
            


            //Repository
            container.RegisterType(typeof(IRepositoryBase<,>), typeof(RepositoryBase<,>));

            container.RegisterType<IRepositoryPessoa, RepositoryPessoa>(new HierarchicalLifetimeManager());
            //container.RegisterType<IRepositoryJogo, RepositoryJogo>(new HierarchicalLifetimeManager());
            
            

        }
    }
}
