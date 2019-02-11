using Learn.CSharp7.Common;
using Learn.CSharp7.Common.Utilis;
using System;
using static System.Console;

namespace Learn.MiscDemo
{

    public class GenericTryParseDemo : IDemoDataType
    {

        public void ShowDemo(ConsoleColor foreGroundColor)
        {
            ForegroundColor = foreGroundColor;

            var genericTryParse = new GenericTryParse();
            int getNumber = 0;
            genericTryParse.TryParse("2468", ref getNumber);
            WriteLine($"GenericTryParse::TryParse Int: {getNumber}");

            DateTime dateTime = DateTime.Now;
            genericTryParse.TryParse("01-Aug-2016", ref dateTime);
            WriteLine($"GenericTryParse::TryParse DateTime: {dateTime}");

            bool results = false;
            genericTryParse.TryParse("true", ref results);
            WriteLine($"GenericTryParse::TryParse Bool: {results}");

            float salary = 0.0f;
            genericTryParse.TryParse("125.67", ref salary);
            WriteLine($"GenericTryParse::TryParse Float: {salary}");
        }

    }

}
