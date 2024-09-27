using TodoProject.Model;
namespace TodoProject.Service
{
    public interface ITodoService:IService<Todo>
    {
        /*
        void GetByTitleHas();       
            get title
            (CheckNullOrBlank)
                ask again
            List<Todo> tasks = todoRepository.GetByTitleHas(title)
            if tasks.Length == 0
                cw "There aren't any tasks with a suiting title"
            else
                tasks.ForEach(t => cw(t);
              
                
        void GetByPriority();
            Priority priority = AskForPriority();
            List<Todo> tasks = todorepository.GetByPriority(Priority)
            if tasks.Length == 0
                cw $"There aren't any tasks with the Priority {priority}"
            else
                tasks.ForEach(t => cw(t));
        
        void GetByStatus();
            Status status = AskForStatus();
            List<Todo> tasks = todorepository.GetByStatus(status)
            if tasks.Length == 0
                cw $"There aren't any tasks with the Status {status}"
            else
                tasks.ForEach(t => cw(t));
        
        void GetAll();
        List<Todo> tasks = todoRepository.GetAll();
        tasks.ForEach(t=>cw(t));

        void GetById();
            Guid id = GetGuidFromUser();
            Todo task = GetById(id);
        if(task == null)
            cw "There aren't any tasks with the id you've provided."

        void Add();
        
        void Update();
        void Delete();

         */
        void GetByTitleHas();       
        void GetByPriority();
        void GetByStatus();
        
    }
}
