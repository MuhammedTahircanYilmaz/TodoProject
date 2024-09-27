namespace TodoProject.Model.ReturnModels;
public class ReturnModel<T>
{
    public string Message {  get; set; }
    public bool Success { get; set; }
    public T? Data { get; set; }

    public override string ToString()
    {
        return $"Message: {Message}," +
            $"\n Success: {Success}," +
            $"\n Data:    {Data}";
    }

}
