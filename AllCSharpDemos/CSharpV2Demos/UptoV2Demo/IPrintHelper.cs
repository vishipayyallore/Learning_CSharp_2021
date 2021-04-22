namespace UptoV2Demo
{
    public interface IPrintHelper
    {
        void Print(string[] items);

        void Print<T>(T items);
    }

}
