using Domain.Core.Interfaces.Repositorys;
using Domain.Models;
using Infrastructure.Data;
using Infrastruture.Repository.Repositorys;

namespace Repositorys
{
    public class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        public RepositoryProduto(SqlContext context): base(context)
        {
        }
    }
}