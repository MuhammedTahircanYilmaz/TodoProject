using System;
namespace TodoProject.Exceptions;

public sealed class TaskNotFoundException : Exception
{
    public TaskNotFoundException()
    {
    }

    public TaskNotFoundException(string message)
        : base(message)
    {
    }

    public TaskNotFoundException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
