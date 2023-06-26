using Application.DTO.DTOS;
using Application.Interfaces;
using Domain.Core.Interfaces.Services;
using Infrastructure.CrossCutting.Adapter.Interfaces;

namespace Application.Service
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IMapperCliente _mapperCliente;
        private readonly IServiceCliente _serviceCliente;

        public ApplicationServiceCliente(IServiceCliente serviceCliente, IMapperCliente mapperCliente)
        {
            _serviceCliente = serviceCliente;
            _mapperCliente = mapperCliente;
        }

        public void Add(ClienteDTO obj)
        {
            var objCliente = _mapperCliente.MapperToEntity(obj);
            _serviceCliente.Add(objCliente);
        }

        public IEnumerable<ClienteDTO> GetAll()
        {
            var objProdutos = _serviceCliente.GetAll();
            return _mapperCliente.MapperToEntity(objProdutos);
        }

        public ClienteDTO? GetById(int id)
        {
            var cliente = _serviceCliente.GetById(id);
            return _mapperCliente.MapperToDTO(cliente);
        }

        public void Remove(ClienteDTO obj)
        {
            var objCliente = _mapperCliente.MapperToEntity(obj);
            _serviceCliente.Remove(objCliente);
        }

        public void Update(ClienteDTO obj)
        {
            var objCliente = _mapperCliente.MapperToEntity(obj);
            _serviceCliente.Update(objCliente);
        }
    }
}