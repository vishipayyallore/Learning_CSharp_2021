using System;

namespace UptoV2Demo
{

    public class PrintHelper : IPrintHelper
    {

        public void Print(string[] items)
        {
            int index = 1;

            Array.ForEach(items, item =>
            {
                Console.WriteLine($"{index++}. {item}");
            });
        }

        public void Print<T>(T items)
        {
            int index = 1;

            foreach(var item in items as string[])
            {
                Console.WriteLine($"{index++}. {item}");
            }
        }
    }

}
