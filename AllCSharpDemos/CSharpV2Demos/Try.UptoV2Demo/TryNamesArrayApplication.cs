using System;
using UptoV2Demo;

namespace Try.UptoV2Demo
{
    public class TryNamesArrayApplication
    {
        private readonly INamesArray _namesArray;
        private readonly IPrintHelper _printHelper;

        public TryNamesArrayApplication(INamesArray namesArray, IPrintHelper printHelper)
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
            _printHelper.Print(_namesArray.GenerateNames(10));
        }
    }
}
