using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class PeekTestModule
    {
        private static string m_strMark = "----------------------------------------------------------------";
        public PeekTestModule() { }
        public static EnumResult Start(Queue<int> queue)
        {
            while (true)
            {
                Console.WriteLine(m_strMark);
                Console.WriteLine("1)Peek  m)Main Menu  e)Exit");
                Console.WriteLine("Please input an instuction:");
                string strInput = Console.ReadLine().ToLower();

                switch (strInput)
                {
                    case "1":
                        TryToPeek(queue);
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
        public static void TryToPeek(Queue<int> queue)
        {
            try
            {
                int iPeek = queue.Peek();
                Console.WriteLine("{0} is peeked.", iPeek);
            }
            catch (QueueException e)
            {
                Console.WriteLine("Warning: " + e.Message);
            }
        }
    }
}
