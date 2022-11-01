namespace ProdutosApi.Backend.Models.ViewModel;

public class Result<T>
{
    public Result(T data, List<string> errors)
    {
        Data = data;
        Errors = errors;
    }

    public Result(T data)
    {
        Data = data;
    }

    public Result(List<string> errors)
    {
        Errors = errors;
    }

    public Result(string error)
    {
        Errors.Add(error);
    }

    public T Data { get; private set; }
    public List<string> Errors { get; private set; } = new();
}
