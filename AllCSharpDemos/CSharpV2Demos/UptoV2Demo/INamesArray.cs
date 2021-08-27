namespace UptoV2Demo
{

    public interface INamesArray
    {
    
        string[] GenerateNames(int numberOfNames = 10, int nameLength = 10);

        // TODO: Generate names from File, Database, API
        // string[] GenerateNames(int numberOfNames = 10, int nameLength = 10);
    }

}
