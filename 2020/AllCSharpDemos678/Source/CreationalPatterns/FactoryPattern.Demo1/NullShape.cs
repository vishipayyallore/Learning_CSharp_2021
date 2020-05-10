using ApplicationCore.Entities;

namespace FactoryPattern.Demo1
{
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

}
