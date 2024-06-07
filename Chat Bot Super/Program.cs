using System.Text;
using System;

Console.Clear();
Console.WriteLine(CreditsJakub());
Chat();


void Chat()
{
    Console.WriteLine("Hi I'm Andrea");
    Console.WriteLine("I'm a junior developer from Brno.");
    Console.WriteLine("I love indie music, weird movies and serial killers.");


    Console.WriteLine("What do you want?");

    // Adel introduction
    Console.WriteLine("One of my devs is also Adela, by the way...");
    Console.WriteLine("What can I tell, we can't choose our parents, it does not matter if you are a program or a living organism. But she tried.");
    Console.WriteLine("It was a joke. She is cute. All my devs are big cutie pies <3");

    string input;
    do
    {
        input = Console.ReadLine();
    } while (string.IsNullOrEmpty(input));

    var theme = TopicHandler.RecognizeTheme(input);

    if (theme != null)
    {
        switch (theme)
        {
            case SupportedTopic.Movies:
                Console.WriteLine(TopicHandler.GetTopTenMovies());
                break;
            case SupportedTopic.Weather:
                Console.WriteLine(TopicHandler.GetDayFromQuestion(input));
                break;
            case SupportedTopic.NumberSort:
                Console.WriteLine(TopicHandler.ExtractAndSortIntegers(input));
                break;
            case SupportedTopic.DayInWeek:
                Console.WriteLine(TopicHandler.TalkDayInWeek(input));
                break;
        }
        Chat();
    }
    else
    {
        Console.WriteLine("Could not recognize theme");
        Chat();
    }
}

string CreditsJakub()
{
    var sb = new StringBuilder();
    sb.AppendLine("Ahoj,");
    sb.AppendLine("já jsem Kubass hoď si provaz!");
    sb.AppendLine("Poslouchám hip hop a neposlouchám autority.");
    sb.AppendLine("A to je asi tak vše o mě. Čau.");
    return sb.ToString();
}