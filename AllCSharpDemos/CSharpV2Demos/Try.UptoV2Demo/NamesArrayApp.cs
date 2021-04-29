using System;
using UptoV2Demo;

namespace Try.UptoV2Demo
{
    public class NamesArrayApp
    {
        private readonly INamesArray _namesArray;
        private readonly IPrintHelper _printHelper;

        public NamesArrayApp(INamesArray namesArray, IPrintHelper printHelper)
        {
            _namesArray = namesArray ?? throw new ArgumentNullException(nameof(namesArray));

            _printHelper = printHelper ?? throw new ArgumentNullException(nameof(printHelper));
        }

        // Application starting point
        public void Run()
        {
            // Version 1
            //Array.ForEach(_namesArray.GenerateNames(5), name =>
            //{
            //    Console.WriteLine($"{name}");
            //});

            // Version 2\.
            Random _random = new();
            _printHelper.Print(_namesArray.GenerateNames(numberOfNames: 10, nameLength: _random.Next(1, 10)));
        }

    }

}
