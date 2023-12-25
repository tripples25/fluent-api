namespace ObjectPrinting
{
    public class ObjectPrinter
    {
        public static PrintingConfig<T> For<T>(int maxNestingLevel = 10)
        {
            return new PrintingConfig<T>(maxNestingLevel);
        }
    }
}