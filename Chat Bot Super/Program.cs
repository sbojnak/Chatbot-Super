using Chat_Bot_Super.Topics;

IInputHandler inputHandler = new ConsoleInputHandler();

Console.Clear();
Chat();

void Chat()
{
    var input = inputHandler.GetUserInput();

    if (TopicHandler.RecognizeTopic(input, out var topic))
        Console.WriteLine(TopicHandler.GetAnswer(topic, input));
    else
        Console.WriteLine("Sorry, I don't understand. Try again.");
}