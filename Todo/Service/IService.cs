using TodoProject.Model.ReturnModels;

namespace TodoProject.Service;
public interface IService<TEntity>
{
    ReturnModel<TEntity> GetAll();
    ReturnModel<TEntity> GetById();
    void Add();
    void Update();
    void Delete();
}
