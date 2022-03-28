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
            yield return new object[] { 7, new LinkedList(), new LinkedList(7) };
            yield return new object[] { 7, new LinkedList(7), new LinkedList(new int[] { 7, 7 }) };
            yield return new object[] { 8, new LinkedList(7), new LinkedList(new int[] { 7, 8 }) };
            yield return new object[] { 7, new LinkedList(new int[] { 7, 7 }), new LinkedList(new int[] { 7, 7, 7 }) };
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

    public class DeleteByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 0, new LinkedList(new int[] { 7, 5 }), new LinkedList(5) };
            yield return new object[] { 1, new LinkedList(new int[] { 7, 5 }), new LinkedList(new int[] { 7 }) };
            yield return new object[] { 0, new LinkedList(new int[] { 2, 7, 9 }), new LinkedList(new int[] { 7, 9 }) };
            yield return new object[] { 1, new LinkedList(new int[] { 2, 7, 9 }), new LinkedList(new int[] { 2, 9 }) };
            yield return new object[] { 2, new LinkedList(new int[] { 2, 7, 9 }), new LinkedList(new int[] { 2, 7 }) };
            yield return new object[] { 3, new LinkedList(new int[] { 0, 8, 2, 7, 9, 8, 0 }), new LinkedList(new int[] { 0, 8, 2, 9, 8, 0 }) };
        }
    }

    public class DeleteElementsAtTheEndTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 1, new LinkedList(5), new LinkedList() };
            yield return new object[] { 1, new LinkedList(new int[] { 7, 5 }), new LinkedList(7) };
            yield return new object[] { 2, new LinkedList(new int[] { 7, 5 }), new LinkedList() };
            yield return new object[] { 2, new LinkedList(new int[] { 2, 7, 9 }), new LinkedList(new int[] { 2 }) };
            yield return new object[] { 3, new LinkedList(new int[] { 2, 7, 9 }), new LinkedList() };
            yield return new object[] { 3, new LinkedList(new int[] { 2, 7, 9, 6, 8 }), new LinkedList(new int[] { 2, 7 }) };
        }
    }

    public class DeleteElementsAtBeginTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 1, new LinkedList(5), new LinkedList() };
            yield return new object[] { 1, new LinkedList(new int[] { 7, 5 }), new LinkedList(5) };
            yield return new object[] { 2, new LinkedList(new int[] { 7, 5 }), new LinkedList() };
            yield return new object[] { 2, new LinkedList(new int[] { 2, 7, 9 }), new LinkedList(new int[] { 9 }) };
            yield return new object[] { 3, new LinkedList(new int[] { 2, 7, 9 }), new LinkedList() };
            yield return new object[] { 3, new LinkedList(new int[] { 2, 7, 9, 6, 8 }), new LinkedList(new int[] { 6, 8 }) };
            yield return new object[] { 2, new LinkedList(new int[] { 2, 0, 0, 6, 8 }), new LinkedList(new int[] { 0, 6, 8 }) };
        }
    }

    public class DeleteElementsByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 1, 0, new LinkedList(5), new LinkedList() };
            yield return new object[] { 1, 0, new LinkedList(new int[] { 7, 5 }), new LinkedList(5) };
            yield return new object[] { 1, 1, new LinkedList(new int[] { 7, 5 }), new LinkedList(7) };
            yield return new object[] { 2, 0, new LinkedList(new int[] { 7, 5 }), new LinkedList() };
            yield return new object[] { 1, 0, new LinkedList(new int[] { 2, 7, 9 }), new LinkedList(new int[] { 7, 9 }) };
            yield return new object[] { 1, 1, new LinkedList(new int[] { 2, 7, 9 }), new LinkedList(new int[] { 2, 9 }) };
            yield return new object[] { 1, 2, new LinkedList(new int[] { 2, 7, 9 }), new LinkedList(new int[] { 2, 7 }) };
            yield return new object[] { 2, 0, new LinkedList(new int[] { 2, 7, 9 }), new LinkedList(new int[] { 9 }) };
            yield return new object[] { 2, 1, new LinkedList(new int[] { 2, 7, 9 }), new LinkedList(new int[] { 2 }) };
            yield return new object[] { 2, 1, new LinkedList(new int[] { 2, 7, 9, 6 }), new LinkedList(new int[] { 2, 6 }) };
            yield return new object[] { 3, 0, new LinkedList(new int[] { 2, 7, 9 }), new LinkedList() };
            yield return new object[] { 3, 2, new LinkedList(new int[] { 2, 7, 9, 6, 8 }), new LinkedList(new int[] { 2, 7 }) };
            yield return new object[] { 2, 2, new LinkedList(new int[] { 2, 0, 0, 6, 8 }), new LinkedList(new int[] { 2, 0, 8 }) };
            yield return new object[] { 2, 1, new LinkedList(new int[] { 2, 0, 0, 6, 8 }), new LinkedList(new int[] { 2, 6, 8 }) };
        }
    }

    public class SearchIndexByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 5, new LinkedList(5), 0 };
            yield return new object[] { 1, new LinkedList(new int[] { 7, 5 }), -1 };
            yield return new object[] { 2, new LinkedList(new int[] { 7, 2 }), 1 };
            yield return new object[] { 2, new LinkedList(new int[] { 2, 7, 9 }), 0 };
            yield return new object[] { 9, new LinkedList(new int[] { 2, 7, 9 }), 2 };
            yield return new object[] { 6, new LinkedList(new int[] { 2, 7, 9, 6, 8 }), 3 };
            yield return new object[] { 0, new LinkedList(new int[] { 2, 0, 0, 6, 8 }), 1 };
        }
    }

    public class GetMaxTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new LinkedList(5), 5 };
            yield return new object[] { new LinkedList(new int[] { 7, 5 }), 7 };
            yield return new object[] { new LinkedList(new int[] { 7, 2 }), 7 };
            yield return new object[] { new LinkedList(new int[] { 2, 7, 9 }), 9 };
            yield return new object[] { new LinkedList(new int[] { -2, -7, -9 }), -2 };
            yield return new object[] { new LinkedList(new int[] { 2, -7, 9, 6, -8 }), 9 };
            yield return new object[] { new LinkedList(new int[] { 2, 0, 0, 6, 8 }), 8 };
        }
    }
    public class GetMinTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new LinkedList(5), 5 };
            yield return new object[] { new LinkedList(new int[] { 7, 5 }), 5 };
            yield return new object[] { new LinkedList(new int[] { 7, 2 }), 2 };
            yield return new object[] { new LinkedList(new int[] { 2, 7, 9 }), 2 };
            yield return new object[] { new LinkedList(new int[] { -2, -7, -9 }), -9 };
            yield return new object[] { new LinkedList(new int[] { 2, -7, 9, 6, -8 }), -8 };
            yield return new object[] { new LinkedList(new int[] { 2, 0, 0, 6, 8 }), 0 };
        }

    }

    public class GetIndexOfMaxTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new LinkedList(5), 0 };
            yield return new object[] { new LinkedList(new int[] { 7, 5 }), 0 };
            yield return new object[] { new LinkedList(new int[] { 2, 7 }), 1 };
            yield return new object[] { new LinkedList(new int[] { 3, 2, 9 }), 2 };
            yield return new object[] { new LinkedList(new int[] { -2, -7, -9 }), 0 };
            yield return new object[] { new LinkedList(new int[] { 2, -7, 9, 6, -8 }), 2 };
            yield return new object[] { new LinkedList(new int[] { 2, 0, 0, 6, 8 }), 4 };
            yield return new object[] { new LinkedList(new int[] { 2, 0, 0, 16, 8 }), 3 };
        }

    }

    public class GetIndexOfMinTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new LinkedList(5), 0 };
            yield return new object[] { new LinkedList(new int[] { 7, 5 }), 1 };
            yield return new object[] { new LinkedList(new int[] { 2, 7 }), 0 };
            yield return new object[] { new LinkedList(new int[] { 3, 2, 9 }), 1 };
            yield return new object[] { new LinkedList(new int[] { -2, -7, -9 }), 2 };
            yield return new object[] { new LinkedList(new int[] { 2, -7, -9, 6, -8 }), 2 };
            yield return new object[] { new LinkedList(new int[] { 2, 0, 0, 6, 8 }), 1 };
            yield return new object[] { new LinkedList(new int[] { 2, 0, 0, 16, -8 }), 4 };
        }

    }


    public class DeleteByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 7, 0, new LinkedList(new int[] { 7, 5 }), new LinkedList(new int[] { 5 }) };
            yield return new object[] { 7, 0, new LinkedList(new int[] { 7 }), new LinkedList() };
            yield return new object[] { 5, 1, new LinkedList(new int[] { 7, 5 }), new LinkedList(new int[] { 7 }) };
            yield return new object[] { 8, 2, new LinkedList(new int[] { 2, 3, 8, 7, 5 }), new LinkedList(new int[] { 2, 3, 7, 5 }) };
            yield return new object[] { 5, 4, new LinkedList(new int[] { 2, 3, 8, 7, 5 }), new LinkedList(new int[] { 2, 3, 8, 7 }) };
            yield return new object[] { 2, 0, new LinkedList(new int[] { 2, 3, 8, 7, 5 }), new LinkedList(new int[] { 3, 8, 7, 5 }) };
            yield return new object[] { 3, 1, new LinkedList(new int[] { 2, 3, 3, 8, 7, 5 }), new LinkedList(new int[] { 2, 3, 8, 7, 5 }) };
        }



    }
}