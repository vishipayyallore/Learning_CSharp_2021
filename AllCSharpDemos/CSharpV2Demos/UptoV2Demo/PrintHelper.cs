using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

using static System.Console;

namespace UptoV2Demo
{

    public class PrintHelper : IPrintHelper
    {

        public void Print(string[] items)
        {
            int index = 1;

            Array.ForEach(items, item =>
            {
                WriteLine($"{index++}. {item} ({item.Length})");
            });
        }

        public void Print(ArrayList items)
        {
            int index = 1;

            foreach (var item in items)
            {
                WriteLine($"{index++}. {item} ({item.ToString().Length})");
            }
        }

        public void Print(StringCollection items)
        {
            int index = 1;

            foreach (var item in items)
            {
                WriteLine($"{index++}. {item} ({item.Length})");
            }
        }

        public void Print(List<string> items)
        {
            int index = 1;

            items.ForEach((item) => WriteLine($"{index++}. {item} ({item.Length})"));
        }

    }

}
