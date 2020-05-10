namespace ExecuteCS678
{

    public static class ShapeFactory
    {
        public static IShape RetrieveShapeObject(string shapeName)
        {
            IShape shape = new NullShape();

            switch (shapeName)
            {
                case "Rectangle":
                    shape = new Rectangle();
                    break;
                case "Square":
                    shape = new Rectangle();
                    break;
            }

            return shape;
        }
    }

    public interface IShape
    {
        ShapeResponse GetDetails();
    }

    public class Rectangle : IShape
    {

        public ShapeResponse GetDetails()
        {
            var shapeResponse = new ShapeResponse()
            {
                Name = nameof(Rectangle),
                Description = "Rectangle details."
            };

            return shapeResponse;
        }
    }

    public class Square : IShape
    {
        public ShapeResponse GetDetails()
        {
            var shapeResponse = new ShapeResponse()
            {
                Name = nameof(Square),
                Description = "Square details."
            };

            return shapeResponse;
        }
    }

    public class NullShape : IShape
    {
        public ShapeResponse GetDetails()
        {
            var shapeResponse = new ShapeResponse()
            {
                Name = nameof(NullShape),
                Description = "No details."
            };

            return shapeResponse;
        }
    }

    public class ShapeResponse
    {
        public string Name { get; set; }

        public string  Description { get; set; }
    }

}
