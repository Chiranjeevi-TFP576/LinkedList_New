namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Queue Problem!");
            QueueList linkedListQueue = new QueueList();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Display();
            Console.ReadKey();
        }
    }
}