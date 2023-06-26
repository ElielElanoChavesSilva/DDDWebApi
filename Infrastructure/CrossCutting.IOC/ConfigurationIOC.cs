using Application.Interfaces;
using Application.Service;
using Autofac;
using Domain.Core.Interfaces.Repositorys;
using Domain.Core.Interfaces.Services;
using Domain.Services.Services;
using Infrastructure.CrossCutting.Adapter.Interfaces;
using Infrastructure.CrossCutting.Adapter.Map;
using Infrastructure.Repository.Repositorys;
using Repositorys;

namespace Infrastruture.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region Registra IOC

            #region IOC Application
            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
            #endregion

            #region IOC Services
            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();
            #endregion

            #region IOC Repositorys SQL
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            #endregion

            #region IOC Mapper
            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();
            #endregion

            #endregion

        }
    }
}