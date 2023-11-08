using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class DequeueTestModule
    {        
        private static string m_strMark = "----------------------------------------------------------------";
        public DequeueTestModule() { }
        public static EnumResult Start(Queue<int> queue)
        {
            while (true)
            {   
                Console.WriteLine(m_strMark);
                Console.WriteLine("1)Dequeue  m)Main Menu  e)Exit");
                Console.WriteLine("Please input an instuction:");
                string strInput = Console.ReadLine().ToLower();

                switch (strInput)
                {
                    case "1":
                        TryToDequeueValue(queue);
                        break;
                    case "m":
                        return EnumResult.MAINMENU;
                    case "e":
                        return EnumResult.EXIT;
                    default:
                        {
                            Console.WriteLine("The input is invalid. Please enter a valid instruction.");
                            continue;
                        }
                }
            }
        }
        public static void TryToDequeueValue(Queue<int> queue)
        {
            try
            {
                int iDequeue = queue.Dequeue();
                Console.WriteLine("{0} is dequeued.", iDequeue);
            }
            catch (QueueException e)
            {
                Console.WriteLine("Warning: " + e.Message);
            }
        }
    }
}
