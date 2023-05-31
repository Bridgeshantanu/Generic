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
            Console.WriteLine("----------------------------");

            TestClass testClass2 = new TestClass();
            Console.WriteLine(testClass2.stringCompare("peach", "banana", "apple"));
            Console.WriteLine(testClass2.stringCompare("banana", "peach", "apple"));
            Console.WriteLine(testClass2.stringCompare("apple", "banana", "peach"));
            Console.WriteLine("----------------------------");

            TestClass1 test = new TestClass1();
            Console.WriteLine(test.CompareAll<int>(4, 3, 2));
            Console.WriteLine(test.CompareAll<float>(4.1f, 3.2f, 2.3f));
            Console.WriteLine(test.CompareAll<string>("apple", "banana", "peach"));
            Console.WriteLine("----------------------------");

            TestClass2<int> test1 = new TestClass2<int>();
            Console.WriteLine(test1.CompareAll(5, 3, 2));
            TestClass2<float> test2 = new TestClass2<float>();
            Console.WriteLine(test2.CompareAll(4.8f, 3.2f, 2.3f));
            TestClass2<string> test3 = new TestClass2<string>();
            Console.WriteLine(test3.CompareAll("apple", "banana", "peach"));
            Console.WriteLine("----------------------------");

            Extend extend = new Extend();
            Console.WriteLine(extend.Max<int>(10, 30, 20, 40, 15));
            Console.WriteLine(extend.Max<float>(1.2f, 3.2f, 2.2f, 4.2f, 1.5f));
            Console.WriteLine(extend.Max<string>("apple", "banana", "peach", "mango", "orange"));
            Console.WriteLine("----------------------------");

            PrintMax print = new PrintMax();
            int max = print.Max<int>(10, 30, 20, 40, 15);
            Console.WriteLine("the maximun value is= " + max);
            float max1 = print.Max<float>(1.2f, 3.2f, 2.2f, 4.2f, 1.5f);
            Console.WriteLine("the maximun value is= " + max1);
            string max2 = print.Max<string>("apple", "banana", "peach", "mango", "orange");
            Console.WriteLine("The maximum value is= " + max2);



        }
    }
}