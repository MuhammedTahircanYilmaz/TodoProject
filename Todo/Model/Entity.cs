namespace TodoProject.Model;

public abstract class Entity<TId> 
{
    public TId Id { get; set; }
}

