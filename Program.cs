using GenericsProj;
using System;

gstack<int> gstack = new gstack<int>(10);
gqueue<ChatMessage> gqueue = new gqueue<ChatMessage>(10);

int msgId=0;


try
{
    while (true)
    {
        Console.WriteLine("Main Menu");
        Console.WriteLine("1.Stack");
        Console.WriteLine("2.Queue");
        Console.WriteLine("3.Exit");
        Console.Write("Input: ");

        var choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                StackMenu();
                break;
            case 2:
                QueueMenu();
                break;
            case 3:
                return;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
    }
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}        


void StackMenu()
{

    Console.WriteLine("Stack");
    Console.WriteLine("1. Push");
    Console.WriteLine("2. Pop");
    Console.WriteLine("3. Peek");
    Console.WriteLine("4. Check if Empty");
    Console.WriteLine("5. Return to Main Menu");
    Console.Write("Input: ");

    var inp = Convert.ToInt32(Console.ReadLine());

    switch (inp)
    {
        case 1:
            var number=0;
            Console.WriteLine("Enter an integer");

            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch 
            { 
                Console.WriteLine("Incorrect Input");
                break;
            }

            gstack.Push(number);
            break;

        case 2:
            var popped = gstack.Pop();
            Console.WriteLine($"{popped} popped from the stack.");
            break;
        case 3:
            var peeked = gstack.Peek();
            Console.WriteLine($"{peeked} is on top of the stack.");
            break;
        case 4:
            Console.WriteLine(gstack.IsEmpty());
            break;
        case 5:
            return;
        default:
            Console.WriteLine("Invalid option");
            break;

    }

}


void QueueMenu()
{
    Console.WriteLine("Queue Operations:");
    Console.WriteLine("1. Enqueue");
    Console.WriteLine("2. Dequeue");
    Console.WriteLine("3. Check if Empty");
    Console.WriteLine("4. Check if Full");
    Console.WriteLine("5. Return to Main Menu");
    Console.Write("Input: ");

    var inp = Convert.ToInt32(Console.ReadLine());

    switch (inp)
    {
        case 1:
            Console.WriteLine("Enter message");
            string content = Console.ReadLine();
            gqueue.enqueue(new ChatMessage
            {
                MessageId = ++msgId,
                Content = content,
                TimeStamp = DateTime.Now,
                SourceId = msgId
            });
            Console.WriteLine("ChatMessage enqueued.");
            break;
        case 2:
            ChatMessage dequeuedMessage = gqueue.dequeue();
            if (dequeuedMessage==null)
            {
                Console.WriteLine("No message in queue");
                break;
            }
            Console.WriteLine($"Dequeued message: ID {dequeuedMessage.MessageId}, Content: {dequeuedMessage.Content}, TimeStamp: {dequeuedMessage.TimeStamp}, SourceId: {dequeuedMessage.SourceId}");
            break;
        case 3:
            Console.WriteLine(gqueue.IsEmpty());
            break;
        case 4:
            Console.WriteLine(gqueue.IsFull());
            break;
        case 5:
            return;
        default:
            Console.WriteLine("Invalid option");
            break;
    }

}