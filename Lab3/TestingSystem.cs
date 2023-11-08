using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//The testing system is divided into several modules to test Enqueue, Dequeue, Peek, Clear and formatted Print.
//Cui 20230427
namespace Lab3
{
    enum EnumResult
    {
        FAILED = -1,
        EXIT = 0,
        SUCCEED,
        PREVIOUS,
        CONTINUE,
        MAINMENU,
    }
    internal class TestingSystem
    {
        private Queue<int> m_queue = new Queue<int>();
        private static string m_strMark = "----------------------------------------------------------------";
        public TestingSystem() { }
        public void Launch()
        {
            Console.WriteLine(m_strMark);
            Console.WriteLine("          Welcome to the testing system of Queue.");
            Console.WriteLine(m_strMark);

            while (true)
            {
                Console.WriteLine(m_strMark);
                string strOption;
                Console.WriteLine("1)Enqueue Test  2)Dequeue Test  3)Peek Test  4)Print Formatted Queue  5)Clear Queue  e)Exit");
                strOption = Console.ReadLine().ToLower();
                EnumResult enumResult = EnumResult.CONTINUE;
                switch (strOption)
                {
                    case "1":
                        enumResult = EnqueueTestModule.Start(m_queue);
                        break;
                    case "2":
                        enumResult = DequeueTestModule.Start(m_queue);
                        break;
                    case "3":
                        enumResult = PeekTestModule.Start(m_queue);
                        break;
                    case "4":
                        enumResult = PrintModule.Print(m_queue);
                        break;
                    case "5":
                        m_queue.Clear();
                        Console.WriteLine("The queue has cleared.");
                        break;
                    case "e":
                        enumResult = EnumResult.EXIT;
                        break;
                    default:
                        {
                            Console.WriteLine("The input is invalid. Please enter a valid instruction.");
                            continue;
                        }
                }
                //Other status value shouldn't make the system exit except EnumResult.EXIT.
                if (enumResult == EnumResult.EXIT)
                    break;
                /*                else if (enumResult == EnumResult.PREVIOUS || enumResult == EnumResult.SUCCEED || enumResult == EnumResult.MAINMENU)
                                    continue;*/
            }
        }
    }
}
