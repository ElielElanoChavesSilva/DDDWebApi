namespace Infrastructure.CrossCutting.Adapter.Interfaces
{
    public interface IMapperBase<TEntity, TDTO>
    {
        TEntity MapperToEntity(TDTO Dto);

        IEnumerable<TDTO> MapperToEntity(IEnumerable<TEntity> entities);

        TDTO? MapperToDTO(TEntity? entity);

    }
}
