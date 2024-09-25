using TodoProject.Model;
namespace TodoProject.Service
{
    public interface ITodoService
    {
        void GetByTitleHas();
        
        void GetByPriority(Priority priority);
        
        void GetByStatus(Status status);
    }
}
