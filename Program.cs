using System;
using System.Threading;
using System.Windows.Forms;

namespace spambot
{
    //new comment
    // hello world
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mesaj ce va fi spamat:");
            string message=Console.ReadLine();
            Console.WriteLine("De cate ori va fi spamat:");
            int repeat=Convert.ToInt32(Console.ReadLine());
            Thread.Sleep(5000);
            for (int i=0; i<repeat; i++) 
            {
                for (int j=0; j<message.Length; j++)
                {
                    Thread.Sleep(5);
                    char c=message[j];
                    if (c =='(' || c == ')')
                    {
                        SendKeys.SendWait("{"+c.ToString()+"}");
                    }
                    else SendKeys.SendWait(c.ToString());

                }
                if (message[0]=='@')SendKeys.SendWait("{TAB}");
                SendKeys.SendWait("{ENTER}");
                Thread.Sleep(50);
                Console.Write(i.ToString() + " ");
            }
        }
    }
}
