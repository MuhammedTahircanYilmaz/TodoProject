using TodoProject.Model;

namespace TodoProject.Repository;

public class TodoRepository : BaseRepository, ITodoRepository
{

    public List<Todo> GetAll()
    {
        return GetTasks();
    }

    public Todo GetById(int id)
    {
        List<Todo> tasks = GetAll();
        Todo? task = tasks.SingleOrDefault(t => t.Id == id);
        if (task == null)
        {
            Console.WriteLine("The Task you are trying to search could not be found.");
        }
        return task;
    }

    public Todo GetByPriority(Priority priority)
    {
        List<Todo> tasks = GetAll();
        Todo? task = tasks.SingleOrDefault(t => t.Priority == priority);
        if (task == null)
        {
            Console.WriteLine("The Task you are trying to search could not be found.");
        }
        return task;
    }

    public Todo GetByStatus(Status status)
    {
        List<Todo> tasks = GetAll();
        Todo? task = tasks.SingleOrDefault(t => t.Status == status);
        if (task == null)
        {
            Console.WriteLine("The Task you are trying to search could not be found.");
        }
        return task;
    }

    public Todo GetByTitleHas(string title)
    {
        List<Todo> tasks = GetAll();
        Todo task = null;

        tasks.ForEach(t =>
        {
            if (t.Title.Contains(title, StringComparison.InvariantCultureIgnoreCase))
            {
                task = t;
            }
        }
        );
        
        if (task == null)
        {
            Console.WriteLine("The Task you are trying to search could not be found.");
        }
        return task;
    }

    public Todo Add(Todo todo)
    {
        List<Todo> tasks = GetAll();
        tasks.Add(todo);
        return todo;
    }

    public Todo Delete(Todo todo)
    {
        List<Todo> tasks = GetAll();
        tasks.Remove(todo);
        return todo;
    }

    public Todo Update(Todo todo)
    {
        List<Todo> tasks = GetAll();
        Todo task = GetById(todo.Id);
        tasks.Insert(tasks.IndexOf(task), todo);
        return todo;
    }
}

