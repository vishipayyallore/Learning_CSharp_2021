using System;
using System.Collections;
using System.Collections.Specialized;

namespace UptoV2Demo
{

    public class PrintHelper : IPrintHelper
    {

        public void Print(string[] items)
        {
            int index = 1;

            Array.ForEach(items, item =>
            {
                Console.WriteLine($"{index++}. {item} ({item.Length})");
            });
        }

        public void Print(ArrayList items)
        {
            int index = 1;

            foreach (var item in items)
            {
                Console.WriteLine($"{index++}. {item} ({item.ToString().Length})");
            }
        }

        public void Print(StringCollection items)
        {
            int index = 1;

            foreach (var item in items)
            {
                Console.WriteLine($"{index++}. {item} ({item.Length})");
            }
        }

    }

}
