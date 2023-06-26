using Application.DTO.DTOS;
using Application.Interfaces;
using Domain.Core.Interfaces.Services;
using Infrastructure.CrossCutting.Adapter.Interfaces;

namespace Application.Service
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IServiceProduto _serviceProduto;
        private readonly IMapperProduto _mapperProduto;

        public ApplicationServiceProduto(IServiceProduto serviceProduto, IMapperProduto mapperProduto)
        {
            _serviceProduto = serviceProduto;
            _mapperProduto = mapperProduto;
        }

        public void Add(ProdutoDTO obj)
        {
            var objProduto = _mapperProduto.MapperToEntity(obj);
            _serviceProduto.Add(objProduto);
        }
        public IEnumerable<ProdutoDTO> GetAll()
        {
            var objProdutos = _serviceProduto.GetAll();
            return _mapperProduto.MapperToEntity(objProdutos);
        }

        public ProdutoDTO? GetById(int id)
        {
            var produto = _serviceProduto.GetById(id);
            return _mapperProduto.MapperToDTO(produto);
        }

        public void Remove(ProdutoDTO obj)
        {
            var produto = _mapperProduto.MapperToEntity(obj);
            _serviceProduto.Remove(produto);
        }

        public void Update(ProdutoDTO obj)
        {
            var produto = _mapperProduto.MapperToEntity(obj);
            _serviceProduto.Update(produto);
        }

    }
}