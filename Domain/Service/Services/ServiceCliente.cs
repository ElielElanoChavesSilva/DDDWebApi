using Domain.Core.Interfaces.Services;
using Domain.Core.Interfaces.Repositorys;
using Domain.Models;

namespace Domain.Services.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        public readonly IRepositoryCliente _repositoryCliente;

        public ServiceCliente(IRepositoryCliente RepositoryCliente)
            : base(RepositoryCliente)
        {
            _repositoryCliente = RepositoryCliente;
        }
    }
}