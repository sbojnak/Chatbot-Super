Console.Clear();
Chat();


void Chat()
{
    Console.WriteLine("What do you want?");
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