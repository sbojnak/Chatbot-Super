public interface IOutputHandler
{
    public void WriteLine(string text);
}

public class ConsoleOutputHandler : IOutputHandler
{
    public void WriteLine(string text)
    {
        Console.WriteLine(text);
    }
}