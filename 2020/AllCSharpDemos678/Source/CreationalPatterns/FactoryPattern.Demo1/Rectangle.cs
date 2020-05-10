using ApplicationCore.Entities;

namespace FactoryPattern.Demo1
{
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

}
