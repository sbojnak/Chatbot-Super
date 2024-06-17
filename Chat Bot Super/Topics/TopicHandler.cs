using System.Text;
using System.Text.RegularExpressions;
using Chat_Bot_Super.Topics;

public static class TopicHandler
{
    public static readonly Dictionary<SupportedTopic, List<string>> ThemeStrings = new()
    {
        {
            SupportedTopic.Credits, new List<string>
                {"credit"}
        },
        {
            SupportedTopic.DayInWeek, new List<string>
                { "day" }
        },
        {
            SupportedTopic.Weather, new List<string>
                { "weather" }
        },
        {
            SupportedTopic.Movies, new List<string>
                { "movie", "movies" }
        },
        {
            SupportedTopic.NumberSort, new List<string>
                { "sort", "numbers" }
        }
    };

    public static bool RecognizeTopic(string input, out SupportedTopic topic)
    {
        var splitInput = input.Split(new[] { ",", " ", ".", "!", "?" }, StringSplitOptions.TrimEntries);

        Dictionary<SupportedTopic, int> matches = new ();
        foreach (var word in splitInput)
        {
            var matchingEntries = ThemeStrings.Where(kvp => kvp.Value.Contains(word.ToLower())).ToList();
            foreach (var match in matchingEntries)
            {
                if (matches.ContainsKey(match.Key))
                    matches[match.Key] += 1;
                else matches.Add(match.Key, 1);
            }
        }
        
        topic = matches.OrderByDescending(x => x.Value).FirstOrDefault().Key;
        
        if (topic != null)
            return true;
        return false;
    }

    public static string GetAnswer(SupportedTopic topic, string input) =>
    topic switch
    {
        SupportedTopic.Credits => new Credits().GetAnswer(input),
        SupportedTopic.DayInWeek => new DayOfTheWeek().GetAnswer((input)),
        SupportedTopic.Weather => new Weather().GetAnswer((input)),
        SupportedTopic.Movies => new Movies().GetAnswer((input)),
        SupportedTopic.NumberSort => new ExtractAndSortIntegers().GetAnswer(input),
        _ => "Err. You lost me there."
    };
}

public enum SupportedTopic
{
    Credits,
    DayInWeek,
    Weather,
    Movies,
    NumberSort
}