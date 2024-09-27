using TodoProject.Model;
using TodoProject.Exceptions;

namespace TodoProject.Repository;

public class TodoRepository : BaseRepository, ITodoRepository
{

    public List<Todo> GetAll()
    {
        return GetTasks();
    }

    public Todo GetById(Guid id)
    {
        Todo? task = Tasks.SingleOrDefault(t => t.Id == id);
     
        if (task == null)
        {
            throw new TaskNotFoundException("There are no Tasks with the given Id");
        }
        
        return task;
    }

    public List<Todo> GetByPriority(Priority priority)
    {        
        List<Todo>? tasksByPriority = Tasks.FindAll(t => t.Priority == priority);
        
        if (tasksByPriority == null)
        {
            throw new TaskNotFoundException($"There are no Tasks found with the Priority \"{priority}\".");
        }

        return tasksByPriority;
    }

    public List<Todo> GetByStatus(Status status)
    {
        List<Todo> tasks = GetAll();
        List<Todo>? tasksByStatus = Tasks.FindAll(t => t.Status == status);
     
        if (tasksByStatus == null)
        {
            throw new TaskNotFoundException($"There are no Tasks found with the Status \"{status}\".");
        }
    
        return tasksByStatus;
    }

    public List<Todo> GetByTitleHas(string title)
    {
        List<Todo> tasks = GetAll();
        List<Todo> tasksByTitle = tasks.FindAll(t => t.Title.Contains(title,StringComparison.InvariantCultureIgnoreCase));
        
        if (tasksByTitle == null)
        {
            throw new TaskNotFoundException("There are no Tasks found that matches the given Title.");
        }
   
        return tasksByTitle;
    }

    public List<Todo> GetByUserId(long userId)
    {
        List<Todo> tasks = BaseRepository.Tasks;
        List<Todo>? tasksByUser = tasks.FindAll(t => t.UserId == userId);
        if (tasksByUser == null)
        {
            throw new TaskNotFoundException("There are no Tasks found for the provided User.");
        }
        return tasksByUser;
    }

    public Todo Add(Todo todo)
    {
        Tasks.Add(todo);
        return todo;
    }

    public Todo Delete(Todo todo)
    {

        Tasks.Remove(todo);
        return todo;
    }

    public Todo Update(Todo todo)
    {
        Todo task = GetById(todo.Id);
        int index = Tasks.IndexOf(task);
        Tasks.Remove(task);
        Tasks.Insert(index, todo);
        return todo;
    }
}

