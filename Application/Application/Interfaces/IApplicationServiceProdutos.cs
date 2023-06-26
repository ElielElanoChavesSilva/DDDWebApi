using Application.DTO.DTOS;

namespace Application.Interfaces
{
    public interface IApplicationServiceProduto
    {
        void Add(ProdutoDTO obj);

        ProdutoDTO? GetById(int id);

        IEnumerable<ProdutoDTO> GetAll();

        void Update(ProdutoDTO obj);

        void Remove(ProdutoDTO obj);


    }
}