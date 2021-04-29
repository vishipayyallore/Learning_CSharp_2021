using System;
using UptoV2Demo;

namespace Try.UptoV2Demo
{
    public class NamesListStringApp
    {
        private readonly INamesListString _namesListString;
        private readonly IPrintHelper _printHelper;

        public NamesListStringApp(INamesListString namesListString, IPrintHelper printHelper)
        {
            _namesListString = namesListString ?? throw new ArgumentNullException(nameof(namesListString));
            
            _printHelper = printHelper ?? throw new ArgumentNullException(nameof(printHelper));
        }

        // Application starting point
        public void Run()
        {
            Random _random = new();
            _printHelper.Print(_namesListString.GenerateNames(numberOfNames: 10, nameLength: _random.Next(10)));
        }

    }
}
