using System;
using UptoV2Demo;

namespace Try.UptoV2Demo
{
    public class NamesStringCollectionApp
    {
        private readonly INamesStringCollection _namesStringCollection;
        private readonly IPrintHelper _printHelper;

        public NamesStringCollectionApp(INamesStringCollection namesStringCollection, IPrintHelper printHelper)
        {
            _namesStringCollection = namesStringCollection ?? throw new ArgumentNullException(nameof(namesStringCollection));

            _printHelper = printHelper ?? throw new ArgumentNullException(nameof(printHelper));
        }


        // Application starting point
        public void Run()
        {
            Random _random = new();
            _printHelper.Print(_namesStringCollection.GenerateNames(numberOfNames: 10, nameLength: _random.Next(10)));
        }

    }
}
