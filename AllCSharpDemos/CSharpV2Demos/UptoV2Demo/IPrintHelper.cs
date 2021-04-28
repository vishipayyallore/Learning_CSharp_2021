using System.Collections;
using System.Collections.Specialized;

namespace UptoV2Demo
{
    public interface IPrintHelper
    {
        void Print(string[] items);

        void Print(ArrayList items);

        void Print(StringCollection items);
    }

}
