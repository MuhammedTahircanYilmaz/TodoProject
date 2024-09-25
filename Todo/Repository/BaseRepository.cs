using TodoProject.Model;

namespace TodoProject.Repository;

public abstract class BaseRepository
{
    public List<Todo> tasks = new List<Todo>{
       new Todo(1, "Breakfast", "Have breakfast", "24/09/2024", "24/09/2024", "23/09/2024", Priority.TO_BE_DONE_ASAP, Status.COMPLETED, 1),
       new Todo(2, "Course", "Study Coding", startDate : null, endDate : null,"23/09/2024", Priority.VERY_IMPORTANT, Status.ONGOING, 1)
    };

    public List<UserEntity> users = new List<UserEntity>
    {
        new UserEntity(1, "Osman", "Yılmaz", 24, "some@email.com", "Password"),
        new UserEntity(2, "Şemsi", "Taşkıran", 37, "another@email.com", "Password")
    };

    public List<Todo> GetTasks()
    {
        return tasks;
    }

    public List<UserEntity> GetUsers() 
    {
        return users;
    }
}
