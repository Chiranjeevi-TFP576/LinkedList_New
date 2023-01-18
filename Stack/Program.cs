namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Stack Problems");
            StackLink stacklinked = new StackLink();
            stacklinked.LinkedListStack();
            stacklinked.Push(70);
            stacklinked.Push(30);
            stacklinked.Push(56);
            stacklinked.Display();
            stacklinked.Peek(); 
            stacklinked.Pop();
            stacklinked.IsEmpty();
            stacklinked.Display();
            Console.ReadKey();
        }
    }
}