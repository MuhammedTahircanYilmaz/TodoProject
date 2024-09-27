using TodoProject.Model;
using TodoProject.Model.ReturnModels;

namespace TodoProject.Service;

public interface IUserEntityService : IService<UserEntity>
{
    ReturnModel<UserEntity> GetByEmail();
    UserEntity GetUserInfo();
    long GetNextId();
    long GetId();
    string GetName();
    string GetLastName();
    short GetAge();
    string GetEmail();
    string GetPassword();
    void GetUpdatedUser(out UserEntity user, out UserEntity updatedUser);
    void PrintAddedUser(UserEntity user);
    void PrintUpdatedUser(UserEntity user, UserEntity updatedUser);
    void PrintDeletedUser(UserEntity user);
    bool CheckIdExists(long id);
}
