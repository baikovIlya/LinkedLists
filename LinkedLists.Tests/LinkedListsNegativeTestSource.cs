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
    public class EmptyListWithIndexOrCountTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] {0, new LinkedList() };
            yield return new object[] {1, new LinkedList() };
            yield return new object[] {-1, new LinkedList() };
        }
    }

    public class DeleteByIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 1, new LinkedList(1) };
            yield return new object[] { 2, new LinkedList(2) };
            yield return new object[] { 2, new LinkedList(new int[] { 2, 1 }) };
        }
    }

    public class WrongCountTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 0, new LinkedList(new int[] { 2, 1, 3, 1 }) };
            yield return new object[] { -1, new LinkedList(new int[] { 2, 1, 3, 1 }) };
            yield return new object[] { 5, new LinkedList(new int[] { 2, 1, 3, 1 }) };
            
        }
    }

    public class DeleteElementsByIndexEmptyListTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 1, 0, new LinkedList() };
            yield return new object[] { 1, 1, new LinkedList() };
            yield return new object[] { 0, 2, new LinkedList() };
            yield return new object[] { 2, 2, new LinkedList() };
        }
    }
    public class DeleteElementsByIndexWrongCountTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { -1, 0, new LinkedList(6) };
            yield return new object[] { 2, 0, new LinkedList(6) };
            yield return new object[] { 0, 0, new LinkedList(6) };
            yield return new object[] { 3, 0, new LinkedList(new int[] { 5, 6 }) };
        }
    }
    public class DeleteElementsByIndexWrongIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 1, -1, new LinkedList(6) };
            yield return new object[] { 1, 1, new LinkedList(6) };
            yield return new object[] { 2, 1, new LinkedList(new int[] { 6, 7 }) };
            yield return new object[] { 2, -1, new LinkedList(new int[] { 5, 6 }) };
        }
    }


}
