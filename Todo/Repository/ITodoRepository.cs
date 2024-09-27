using TodoProject.Model;

namespace TodoProject.Repository;

public interface ITodoRepository : IRepository<Todo,Guid>
{
    public List<Todo> GetByTitleHas(string title);
    public List<Todo> GetByPriority(Priority priority);
    public List<Todo> GetByStatus(Status status);
    public List<Todo> GetByUserId(long userId);
}

