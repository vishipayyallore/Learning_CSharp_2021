using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace UptoV2Demo
{
    public interface IPrintHelper
    {
        void Print(string[] items);

        void Print(ArrayList items);

        void Print(StringCollection items);

        void Print(List<string> items);
    }

}
