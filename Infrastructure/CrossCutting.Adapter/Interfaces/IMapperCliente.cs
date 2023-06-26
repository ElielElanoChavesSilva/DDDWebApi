using Application.DTO.DTOS;
using Domain.Models;

namespace Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperCliente: IMapperBase<Cliente, ClienteDTO>
    {
    }
}
