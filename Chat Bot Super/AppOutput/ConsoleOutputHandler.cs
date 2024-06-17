/// <summary>
/// Chatbot class for handling output in Console environment.
/// </summary>
public class ConsoleOutputHandler : IOutputHandler
{
    /// <summary>
    /// Write text as a Line in a Console.
    /// </summary>
    /// <param name="text">Text to print.</param>
    public void WriteLine(string text)
    {
        Console.WriteLine(text);
    }
}