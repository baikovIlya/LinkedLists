using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lists;

namespace LinkedLists.Tests
{
    public class AddTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] {7, new LinkedList(), new LinkedList(7)};
            yield return new object[] {7, new LinkedList(7), new LinkedList(new int[] { 7, 7 })};
            yield return new object[] {8, new LinkedList(7), new LinkedList(new int[] { 7, 8 })};
            yield return new object[] {7, new LinkedList(new int[] { 7, 7 }), new LinkedList(new int[] { 7, 7 , 7}) };
        }
    }

    public class AddFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 7, new LinkedList(), new LinkedList(7) };
            yield return new object[] { 7, new LinkedList(7), new LinkedList(new int[] { 7, 7 }) };
            yield return new object[] { 8, new LinkedList(7), new LinkedList(new int[] { 8, 7 }) };
            yield return new object[] { 1, new LinkedList(new int[] { 7, 7 }), new LinkedList(new int[] { 1, 7, 7 }) };
        }
    }

    public class AddByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 7, 0, new LinkedList(), new LinkedList(7) };
            yield return new object[] { 7, 1, new LinkedList(7), new LinkedList(new int[] { 7, 7 }) };
            yield return new object[] { 8, 1, new LinkedList(7), new LinkedList(new int[] { 7, 8 }) };
            yield return new object[] { 8, 0, new LinkedList(7), new LinkedList(new int[] { 8, 7 }) };
            yield return new object[] { 9, 1, new LinkedList(new int[] { 7, 7 }), new LinkedList(new int[] { 7, 9, 7 }) };
        }
    }
    public class DeleteLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new LinkedList(7), new LinkedList() };
            yield return new object[] { new LinkedList(new int[] { 7, 8 }), new LinkedList(7) };
            yield return new object[] { new LinkedList(new int[] { 7, 7, 8 }), new LinkedList(new int[] { 7, 7 }) };

        }
    }

    public class DeleteFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new LinkedList(7), new LinkedList() };
            yield return new object[] { new LinkedList(new int[] { 7, 8 }), new LinkedList(8) };
            yield return new object[] { new LinkedList(new int[] { 7, 7, 8 }), new LinkedList(new int[] { 7, 8 }) };

        }
    }



}
