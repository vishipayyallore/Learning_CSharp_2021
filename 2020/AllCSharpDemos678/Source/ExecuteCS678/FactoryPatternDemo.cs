namespace ExecuteCS678
{
    class FactoryPatternDemo
    {
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
                Name = nameof(Square),
                Description = "No details."
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
                Description = "No details."
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
