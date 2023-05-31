namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestClass testClass = new TestClass();
            Console.WriteLine(testClass.IntCompare(4, 3, 2));
            Console.WriteLine(testClass.IntCompare(3, 4, 2));
            Console.WriteLine(testClass.IntCompare(2, 3, 4));

        }
    }
}