using Application.DTO.DTOS;

namespace Application.Interfaces
{
    public interface IApplicationServiceCliente
    {
        void Add(ClienteDTO obj);

        ClienteDTO? GetById(int id);

        IEnumerable<ClienteDTO> GetAll();

        void Update(ClienteDTO obj);

        void Remove(ClienteDTO obj);

    }
}