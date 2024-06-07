using Chat_Bot_Super.Topics;

IInputHandler inputHandler = new ConsoleInputHandler();

Console.Clear();
Chat();

void Chat()
{

    var input = inputHandler.GetUserInput();

    if (TopicHandler.RecognizeTopic(input, out var topic))
        TopicHandler.GetAnswer(topic, input);
    else
        Console.WriteLine("Sorry, I don't understand. Try again.");
    
    Console.WriteLine("Andrea Habáňová");
    Console.WriteLine("I'm a junior developer from Brno.");
    Console.WriteLine("I love indie music, weird movies and serial killers.");


    Console.WriteLine("What do you want?");

    // Adel introduction
    Console.WriteLine("One of my devs is also Adela, by the way...");
    Console.WriteLine("What can I tell, we can't choose our parents, it does not matter if you are a program or a living organism. But she tried.");
    Console.WriteLine("It was a joke. She is cute. All my devs are big cutie pies <3");

    
}