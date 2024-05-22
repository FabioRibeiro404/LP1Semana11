using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace HowManyOfThisType
{
    public class Checker : IEnumerable<int>
    {
        public static int HowManyOfType<T>(IEnumerable<object> items)
        {
            return items.OfType<T>().Count();
        }

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
