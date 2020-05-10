using ApplicationCore.Entities;

namespace FactoryPattern.Demo1
{
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

}
