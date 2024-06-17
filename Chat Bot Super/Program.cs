using Chat_Bot_Super.Topics;

IInputHandler inputHandler = new ConsoleInputHandler();
IOutputHandler outputHandler = new ConsoleOutputHandler();

Console.Clear();
Chat();

void Chat()
{
    var input = inputHandler.GetUserInput();

    if (TopicHandler.RecognizeTopic(input, out var topic))
        outputHandler.WriteLine(TopicHandler.GetAnswer(topic, input));
    else
        outputHandler.WriteLine("Sorry, I don't understand. Try again.");
}