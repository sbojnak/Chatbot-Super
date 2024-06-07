using System.Text;

Console.Clear();
Console.WriteLine(CreditsJakub());
Chat();


void Chat()
{
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

    var theme = Topics.RecognizeTheme(input);

    if (theme != null)
    {
        switch (theme)
        {
            case SupportedTopic.Movies:
                Console.WriteLine(Topics.GetTopTenMovies());
                break;
            case SupportedTopic.Weather:
                Console.WriteLine(Topics.GetDayFromQuestion(input));
                break;
            case SupportedTopic.NumberSort:
                Console.WriteLine(Topics.ExtractAndSortIntegers(input));
                break;
            case SupportedTopic.DayInWeek:
                Console.WriteLine(Topics.TalkDayInWeek(input));
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