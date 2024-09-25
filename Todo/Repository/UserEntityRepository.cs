
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
        List <UserEntity> users = GetUsers();

        UserEntity? user = users.SingleOrDefault(x => x.Email == email);
        if (user == null)
        {
            Console.WriteLine("The user you are looking for couldn't be found");
        }
        return user;
    }

    public UserEntity GetById(int id)
    {
        List<UserEntity> users = GetUsers();

        UserEntity? user = users.SingleOrDefault(x => x.Id == id);

        if (user == null)
        {
            Console.WriteLine("The user you are looking for couldn't be found");
        }

        return user;
    }

    public UserEntity Add(UserEntity user)
    {
        List<UserEntity> users = GetUsers();

        users.Add(user);

        return user;
    }

    public UserEntity Update(UserEntity updatedUser)
    {
        List<UserEntity> users = GetUsers();

        UserEntity user = GetById(updatedUser.Id);

        users.Insert(users.IndexOf(user), updatedUser);

        return user;
    }

    public UserEntity Delete(UserEntity user)
    {
        List<UserEntity> users = GetUsers();

        users.Remove(user);

        return user;
    }
}

