using Learn.CSharp7.Common;
using static System.Console;

namespace Learn.MiscDemo
{

    /// <summary>
    /// Discard => write-only variable whose name is _ (underscore character).
    /// </summary>
    public class DiscardsDemo : IDataTypeDemo
    {
        public string Title => GetType().Name;

        public void ShowDemo()
        {
            var (_, Name, _, Salary) = (1, "Shiva Sai", 25, 123.45);
            WriteLine($"Name: {Name}, Salary: {Salary}");
        }

    }

}
