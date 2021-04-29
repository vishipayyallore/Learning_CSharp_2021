using System.Collections.Generic;

namespace UptoV2Demo
{

    public interface INamesListString
    {
        List<string> GenerateNames(int numberOfNames = 10, int nameLength = 10);
    }

}
