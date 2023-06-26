using Application.DTO.DTOS;
using Domain.Models;
using Infrastructure.CrossCutting.Adapter.Interfaces;

namespace Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperCliente : IMapperCliente
    {
        #region properties

        private readonly List<ClienteDTO> clienteDTOs = new();

        #endregion

        #region methods

        public Cliente MapperToEntity(ClienteDTO clienteDTO)
        {
            return new()
            {
                Id = clienteDTO.Id,
                Nome = clienteDTO.Nome,
                Sobrenome = clienteDTO.Sobrenome,
                Email = clienteDTO.Email
            };
        }

        public IEnumerable<ClienteDTO> MapperToEntity(IEnumerable<Cliente> clientes)
        {
            foreach (var item in clientes)
            {
                clienteDTOs.Add(new()
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    Sobrenome = item.Sobrenome,
                    Email = item.Email
                });

            }
            return clienteDTOs;
        }
        public ClienteDTO? MapperToDTO(Cliente? cliente)
        {
            if (cliente == null) return null;

            return new()
            {
                Id = cliente.Id,
                Nome = cliente.Nome,
                Sobrenome = cliente.Sobrenome,
                Email = cliente.Email
            };
        }
        #endregion
    }

}