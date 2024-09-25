using TodoProject.Model;

namespace TodoProject.Repository;

public interface IUserEntityRepository: IRepository<UserEntity>
{
    public List<UserEntity> GetAll();
    
    public UserEntity GetById(int id);

    public UserEntity GetByEmail(string email);

    public UserEntity Add(UserEntity user);

    public UserEntity Update(UserEntity user);

    public UserEntity Delete(UserEntity user);

}

