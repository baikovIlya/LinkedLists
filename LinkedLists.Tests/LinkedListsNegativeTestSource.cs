using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lists;

namespace LinkedLists.Tests
{
    public class EmptyListTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new LinkedList() };
        }
    }

    public class AddByIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 7, -1, new LinkedList()};
            yield return new object[] { 7, 2, new LinkedList()};
            yield return new object[] { 7, 1, new LinkedList()};
            yield return new object[] { 7, 2, new LinkedList(2)};
        }
    }


}
