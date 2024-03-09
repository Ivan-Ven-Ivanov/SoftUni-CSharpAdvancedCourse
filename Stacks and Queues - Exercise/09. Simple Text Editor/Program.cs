using System.Text;

namespace _09._Simple_Text_Editor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            Stack<string> undoStack = new Stack<string>();

            undoStack.Push(sb.ToString());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] command = Console.ReadLine()
                    .Split();
                if (command[0] == "1")
                {
                    sb.Append(command[1]);
                    undoStack.Push(sb.ToString());
                }
                else if (command[0] == "2")
                {
                    int removeCount = int.Parse(command[1]);
                    sb.Remove(sb.Length - removeCount, removeCount);
                    undoStack.Push(sb.ToString());
                }
                else if (command[0] == "3")
                {
                    int elementToReturn = int.Parse(command[1]);
                    Console.WriteLine(sb[elementToReturn - 1]);
                }
                else if (command[0] == "4" && undoStack.Count > 0)
                {
                    string text = undoStack.Pop();
                    sb = new StringBuilder(undoStack.Peek());
                }
            }
        }
    }
}