using System;
using System.Threading;
using System.Windows.Forms;

namespace spambot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message=Console.ReadLine();
            Thread.Sleep(5000);
            for (int i=0; i<250; i++) 
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
