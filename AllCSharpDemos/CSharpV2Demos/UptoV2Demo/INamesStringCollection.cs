using System.Collections.Specialized;

namespace UptoV2Demo
{

    public interface INamesStringCollection
    {
        StringCollection GenerateNames(int numberOfNames = 10, int nameLength = 10);
    }

}
