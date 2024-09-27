using TodoProject.Model;

namespace TodoProject.Repository;

public abstract class BaseRepository
{
    public static List<Todo> Tasks = new List<Todo>{
       new Todo(new Guid("{B42EF7D1-1E6A-44E7-B767-CD6E95A4B6F3}"), "Breakfast", "Have breakfast", "24/09/2024", "24/09/2024", "23/09/2024", Priority.TO_BE_DONE_ASAP, Status.COMPLETED, 1),
       new Todo(new Guid("{26552BC7-DD5C-4BC2-86A0-788CC176F692}"), "Course", "Study Coding", startDate : null, endDate : null,"23/09/2024", Priority.VERY_IMPORTANT, Status.ONGOING, 1)
    };

    public static List<UserEntity> Users = new List<UserEntity>
    {
        new UserEntity(1, "Osman", "Yılmaz", 24, "some@email.com", "Password"),
        new UserEntity(2, "Şemsi", "Taşkıran", 37, "another@email.com", "Password")
    };

    public List<Todo> GetTasks()
    {
        return Tasks;
    }

    public List<UserEntity> GetUsers()
    {
        return Users;
    }
}
