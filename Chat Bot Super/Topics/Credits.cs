using System.Text;

namespace Chat_Bot_Super.Topics;

public class Credits : ITopic
{
    public string GetAnswer(string input)
    {
        var sb = new StringBuilder();

        sb.AppendLine(Jakub());
        
        return sb.ToString();
    }

    private string Jakub()
    {
        var sb = new StringBuilder();
        
        sb.AppendLine("Hi,");
        sb.AppendLine("My name is Jakub.");
        sb.AppendLine("It’s not so much as so little as to do with what everything is.");
        sb.AppendLine("But it is within our self-interest to understand the topography of our lives unto ourselves.");
        sb.AppendLine("Common knowledge but important nonetheless.");
        sb.AppendLine("Thank you.");
        
        return sb.ToString();
    }
}