using Learn.MiscDemo;
using Learn.MongoDbDemo;
using Learn.TuplesDemo;
using System;
using static System.Console;

namespace Learn.CSharp7
{
    static class Program
    {
        static void Main(string[] args)
        {
            // ---------------------------------------------------------------------
            var mongoDemos = new StoreNRetrievePerson();
            mongoDemos.SavePerson();

            // ---------------------------------------------------------------------
            var demoHelper = new DemoHelper();

            demoHelper.ShowDemoOf(new DemoTuples(), ConsoleColor.DarkCyan)
                .ShowDemoOf(new GenericTryParseDemo(), ConsoleColor.Green)
                .ShowDemoOf(new OutVariableDemo(), ConsoleColor.Magenta)
                .ShowDemoOf(new DiscardsDemo(), ConsoleColor.Cyan);

            ForegroundColor = ConsoleColor.White;

            WriteLine("\n\nPress any key ...");
            ReadKey();
        }

    }

}
