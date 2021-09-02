using HeaderFooter.Interfaces.Utilities;

using static System.Console;

namespace HeaderFooter.Utilities
{

    public class Footer : IFooter
    {

        public void DisplayFooter(char footer, int length = 100)
        {
            WriteLine($"\n{new string(footer, length)}\n");
        }

    }

}
