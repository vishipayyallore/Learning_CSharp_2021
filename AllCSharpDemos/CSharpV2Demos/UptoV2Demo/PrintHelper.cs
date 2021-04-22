using System;

namespace UptoV2Demo
{

    public class PrintHelper : IPrintHelper
    {

        public void Print(string[] items)
        {
            Array.ForEach(items, item =>
            {
                Console.WriteLine($"{item}");
            });
        }

    }

}
