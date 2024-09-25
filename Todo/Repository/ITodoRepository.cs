using TodoProject.Model;

namespace TodoProject.Repository;

public interface ITodoRepository : IRepository<Todo>
{
    public List<Todo> GetAll();

    public Todo GetById(int id);

    public Todo GetByTitleHas(string title);

    public Todo GetByPriority(Priority priority);

    public Todo GetByStatus(Status status);

    public Todo Add(Todo todo);

    public Todo Update(Todo todo);

    public Todo Delete(Todo todo);

}

