using Application.DTO.DTOS;
using Domain.Models;
using Infrastructure.CrossCutting.Adapter.Interfaces;

namespace Infrastructure.CrossCutting.Adapter.Map
{
    public class MapperProduto : IMapperProduto
    {
        #region Properties

        private readonly List<ProdutoDTO> produtoDTOs = new();

        #endregion
        #region methods
        public Produto MapperToEntity(ProdutoDTO produtoDTO)
        {
            return new()
            {

                Id = produtoDTO.Id,
                Nome = produtoDTO.Nome,
                Valor = produtoDTO.Valor
            };
        }

        public IEnumerable<ProdutoDTO> MapperToEntity(IEnumerable<Produto> produtos)
        {
            foreach (var item in produtos)
            {
                produtoDTOs.Add(new()
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    Valor = item.Valor
                });
            }
            return produtoDTOs;
        }

        public ProdutoDTO? MapperToDTO(Produto? produto)
        {
            if (produto == null) return null;

            return new()
            {
                Id = produto.Id,
                Nome = produto.Nome,
                Valor = produto.Valor
            };
        }

        #endregion
    }
}