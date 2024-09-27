namespace TodoProject.Model;

public sealed class Todo : Entity<Guid>
{
    public Todo()
    {

    }

    public Todo(Guid id, string title, string description, string? startDate, string? endDate, string creationDate, Priority priority, Status status, int userId)
    {
        Id = id;
        Title = title;
        Description = description;
        StartDate = startDate;
        EndDate = endDate;
        CreationDate = creationDate;
        Priority = priority;
        Status = status;
        UserId = userId;
    }
    public string Title { get; set; }

    public string Description { get; set; }

    public string StartDate { get; set; }

    public string EndDate { get; set; }

    public string CreationDate { get; set; }

    public Priority Priority { get; set; }

    public Status Status { get; set; }

    public int UserId { get; set; }

}

