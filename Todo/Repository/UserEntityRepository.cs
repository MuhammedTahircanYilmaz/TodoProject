
using TodoProject.Exceptions;
using TodoProject.Model;

namespace TodoProject.Repository;

public class UserEntityRepository : BaseRepository, IUserEntityRepository
{

    public List<UserEntity> GetAll()
    {
        return GetUsers();
    }

    public UserEntity GetByEmail(string email)
    {   
        UserEntity? user = Users.SingleOrDefault(x => x.Email == email);
        
        if (user == null)
        {
            throw new UserNotFoundException($"There is no User with the email \"{email}\" that could be found");
        }
        
        return user;
    }

    public UserEntity GetById(long id)
    {
        UserEntity? user = Users.SingleOrDefault(x => x.Id == id);

        if (user == null)
        {
            throw new UserNotFoundException($"There is no User with the Id \"{id}\" that could be found");
        }

        return user;
    }

    public UserEntity Add(UserEntity user)
    {
        Users.Add(user);
        return user;
    }

    public UserEntity Update(UserEntity updatedUser)
    {
        UserEntity user = GetById(updatedUser.Id);
        int index = Users.IndexOf(user);

        Users.Remove(user);
        Users.Insert(index, updatedUser);

        return user;
    }

    public UserEntity Delete(UserEntity user)
    {
        List<UserEntity> users = GetUsers();

        users.Remove(user);

        return user;
    }
}

