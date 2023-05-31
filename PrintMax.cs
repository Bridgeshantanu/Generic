using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class PrintMax
    {
        public T Max<T>(params T[] values) where T : IComparable<T>
        {
            if (values == null || values.Length == 0)
            {
                Console.WriteLine("No values provided.");
            }

            T max = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i].CompareTo(max) > 0)
                {
                    max = values[i];
                }
            }

            return max;
        }
    }
}
