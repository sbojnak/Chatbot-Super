using System.Text;

namespace Chat_Bot_Super.Topics;

public class Credits : ITopic
{
    public string GetAnswer(string input)
    {
        var sb = new StringBuilder();

        sb.AppendLine(Jakub());
        sb.AppendLine(Adela());
        sb.AppendLine(Andrea());
        sb.AppendLine(Veronika());

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

    private string Adela()
    {
        var sb = new StringBuilder();

        sb.AppendLine("One of my devs is also Adela, by the way...");
        sb.AppendLine("What can I tell, we can't choose our parents, it does not matter if you are a program or a living organism. But she tried.");
        sb.AppendLine("It was a joke. She is cute. All my devs are big cutie pies <3");

        return sb.ToString();
    }

    private string Andrea()
    {
        var sb = new StringBuilder();

        sb.AppendLine("Hi I'm Andrea");
        sb.AppendLine("I'm a junior developer from Brno.");
        sb.AppendLine("I love indie music, weird movies and serial killers.");

        return sb.ToString();
    }

    private string Veronika()
    {
        var sb = new StringBuilder();

        sb.AppendLine("Hi, I'm Veronika");
        sb.AppendLine("Not sure what to write...");
        sb.AppendLine("I like dogs and ice cream.");

        return sb.ToString();
    }

}