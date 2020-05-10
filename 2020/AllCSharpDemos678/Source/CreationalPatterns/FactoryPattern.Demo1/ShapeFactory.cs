namespace FactoryPattern.Demo1
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

}
