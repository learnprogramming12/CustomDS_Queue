using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab3
{
    internal class EnqueueTestModule
    {
        private static string m_strMark = "----------------------------------------------------------------";
        public EnqueueTestModule() { }

        public static EnumResult Start(Queue<int> queue)
        {
            while (true)
            {
                Console.WriteLine(m_strMark);
                Console.WriteLine("m)Main Menu  e)Exit");
                Console.WriteLine("Please input the value to queue:");
                string strInput = Console.ReadLine().ToLower();

                switch (strInput)
                {
                    case "m":
                        return EnumResult.MAINMENU;
                    case "e":
                        return EnumResult.EXIT;
                    default:
                        {
                            TryToEnqueue(queue, strInput);
                            continue;
                        }
                }
            }
        }
        private static void TryToEnqueue(Queue<int> queue, string strValue)
        {
             bool bValid = int.TryParse(strValue, out int iResult);

            if (!bValid)
            {
                Console.WriteLine("The input is not valid.");
                return;
            }
            try
            { 
                queue.Enqueue(iResult);
                Console.WriteLine("{0} is enqueued.", iResult);
            }
            catch (QueueException e)
            {
                Console.WriteLine("Warning: " + e.Message);
            }
        }
    }
}
