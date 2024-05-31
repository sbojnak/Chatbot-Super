using System;

Console.Clear();
Chat();


void Chat()
{
    Console.WriteLine("Andrea Habáňová");
    Console.WriteLine("I'm a junior developer from Brno.");
    Console.WriteLine("I love indie music, weird movies and serial killers.");


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