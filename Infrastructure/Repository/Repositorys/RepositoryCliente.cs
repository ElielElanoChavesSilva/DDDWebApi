
using Domain.Core.Interfaces.Repositorys;
using Domain.Models;
using Infrastructure.Data;
using Infrastruture.Repository.Repositorys;

namespace Infrastructure.Repository.Repositorys
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        public RepositoryCliente(SqlContext context): base(context)
        {
        }
    }
}
