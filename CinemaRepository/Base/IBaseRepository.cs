using CinemaDomain.Base;

namespace CinemaRepository.Base
{
    public interface IBaseRepository<TypeEntity> where TypeEntity : IBaseEntity
    {
        // Métodos do CRUD
        void Create(TypeEntity entity);
        TypeEntity ReadById(int id);
        IList<TypeEntity> ReadAll();
        void Update(TypeEntity entity);
        void Delete(int id);
    }
}
