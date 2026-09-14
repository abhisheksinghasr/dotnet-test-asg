using System;
using System.Threading;

class Program
{
    static void Main()
    {
        string text = "Hello, World!";
        
        for (int i = 0; i < 30; i++)
        {
            Console.Clear(); // clear screen each frame
            Console.SetCursorPosition(i, 10); // move position
            Console.WriteLine(text);
            Thread.Sleep(100); // control speed
        }
    }
}
