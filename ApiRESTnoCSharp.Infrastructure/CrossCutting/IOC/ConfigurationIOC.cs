using ApiRESTnoCSharp.Application;
using ApiRESTnoCSharp.Application.Interfaces;
using ApiRESTnoCSharp.Application.Interfaces.Mapper;
using ApiRESTnoCSharp.Application.Mapper;
using ApiRESTnoCSharp.Domain.Core.Interfaces.Repositories;
using ApiRESTnoCSharp.Domain.Core.Interfaces.Services;
using ApiRESTnoCSharp.Domain.Services;
using ApiRESTnoCSharp.Infrastructure.Data.Repositories;
using Autofac;

namespace ApiRESTnoCSharp.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();

            #endregion
        }
    }
}
