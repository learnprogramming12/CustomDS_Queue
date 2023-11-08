using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    enum EnumPrintFormat
    {
        WithNewLine = 0,
        WithComma = 1,
        WithIndex,
    }
    internal class PrintFormat
    {
        //added on 20230427
        public static void Print(Queue<int> queue, EnumPrintFormat enumFormat = EnumPrintFormat.WithNewLine)
        {
            string strToken;
            switch (enumFormat)
            {
                case EnumPrintFormat.WithNewLine:
                    strToken = "{0}\n";
                    break;
                case EnumPrintFormat.WithComma:
                    strToken = "{0}, ";
                    break;
                case EnumPrintFormat.WithIndex:
                    strToken = "({0}){1} ";
                    break;
                default:
                    strToken = "{0}\n";
                    break;
            }
            for (int i = 0; i < queue.Count; i++)
            {
                if (enumFormat == EnumPrintFormat.WithIndex)
                    Console.Write(strToken, i, queue.GetElement(i));
                else
                    Console.Write(strToken, queue.GetElement(i));
            }
            Console.WriteLine();
        }
        public static void Print(int []arr, EnumPrintFormat enumFormat = EnumPrintFormat.WithNewLine)
        {
            string strToken;
            switch (enumFormat)
            {
                case EnumPrintFormat.WithNewLine:
                    strToken = "{0}\n";
                    break;
                case EnumPrintFormat.WithComma:
                    strToken = "{0}, ";
                    break;
                case EnumPrintFormat.WithIndex:
                    strToken = "({0}){1} ";
                    break;
                default:
                    strToken = "{0}\n";
                    break;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (enumFormat == EnumPrintFormat.WithIndex)
                    Console.Write(strToken, i, arr[i]);
                else
                    Console.Write(strToken, arr[i]);
            }
            Console.WriteLine();
        }
    }
}
