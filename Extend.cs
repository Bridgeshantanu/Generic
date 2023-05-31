using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Extend
    {
        public T Max<T>(params T[] values) where T : IComparable<T>
        {
            if (values == null || values.Length == 0)
            {
                Console.WriteLine("No values provided.");
            }

            return values.Max();
        }
    }
}
