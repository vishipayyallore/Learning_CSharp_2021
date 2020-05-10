using ApplicationCore.Constants;

namespace FactoryPattern.Demo1
{
    public static class ShapeFactory
    {
        public static IShape RetrieveShapeObject(string shapeName)
        {
            IShape shape = new NullShape();

            switch (shapeName)
            {
                case Constants.Shapes.RECTANGLE:
                    shape = new Rectangle();
                    break;
                case Constants.Shapes.SQUARE:
                    shape = new Rectangle();
                    break;
            }

            return shape;
        }
    }

}
