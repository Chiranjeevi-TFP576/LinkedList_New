namespace LinkedList_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            //list.RemoveFirstNode();
            //list.Display();
            list.RemovaLastNode();
            list.Display();
            Console.ReadKey();
        }
    }
}