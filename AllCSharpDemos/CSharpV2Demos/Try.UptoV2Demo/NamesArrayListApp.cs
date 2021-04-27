using System;
using UptoV2Demo;

namespace Try.UptoV2Demo
{
    public class NamesArrayListApp
    {
        private readonly INamesArrayList _namesArrayList;
        private readonly IPrintHelper _printHelper;

        public NamesArrayListApp(INamesArrayList namesArrayList, IPrintHelper printHelper)
        {
            _namesArrayList = namesArrayList ?? throw new ArgumentNullException(nameof(namesArrayList));

            _printHelper = printHelper ?? throw new ArgumentNullException(nameof(printHelper));
        }

        // Application starting point
        public void Run()
        {
            Random _random = new();
            _printHelper.Print(_namesArrayList.GenerateNames(numberOfNames: 100, nameLength: _random.Next(1, 10)));
        }
    }
}
