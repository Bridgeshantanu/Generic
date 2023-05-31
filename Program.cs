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
            Console.WriteLine("----------------------------");

            TestClass testClass1 = new TestClass();
            Console.WriteLine(testClass1.floatCompare(4.1f, 3.2f, 2.3f));
            Console.WriteLine(testClass1.floatCompare(3.2f, 4.1f, 2.3f));
            Console.WriteLine(testClass1.floatCompare(3.2f, 2.3f, 4.1f));

        }
    }
}