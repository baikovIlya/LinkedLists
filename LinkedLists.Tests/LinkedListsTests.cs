using NUnit.Framework;
using System;
using System.Collections;
using Lists;

namespace LinkedLists.Tests
{
    public class Tests
    {

        [TestCaseSource(typeof(AddTestSource))]
        public void AddTest(int new_element, LinkedList list, LinkedList expected_list)
        {
            list.Add(new_element);
            Assert.AreEqual(expected_list, list);
        }


        [TestCaseSource(typeof(AddFirstTestSource))]
        public void AddLastTest(int new_element, LinkedList list, LinkedList expected_list)
        {
            list.AddFirst(new_element);
            Assert.AreEqual(expected_list, list);
        }


        [TestCaseSource(typeof(AddByIndexTestSource))]
        public void AddByIndexTest(int new_element, int index, LinkedList list, LinkedList expected_list)
        {
            list.AddByIndex(new_element, index);
            Assert.AreEqual(expected_list, list);
        }

        [TestCaseSource(typeof(AddByIndexNegativeTestSource))]
        public void AddByIndexTest_WhenIndexIsWrong_ShouldThrowArgumentException(int element, int index, LinkedList list)
        {
            Assert.Throws<ArgumentException>(() => list.AddByIndex(element, index));
        }


        [TestCaseSource(typeof(DeleteLastTestSource))]
        public void DeleteLastTest(LinkedList list, LinkedList expected_list)
        {
            list.DeleteLast();
            Assert.AreEqual(expected_list, list);
        }

        [TestCaseSource(typeof(EmptyListTestSource))]
        public void DeleteLastTest_WhenListIsEmpty_ShouldThrowException(LinkedList list)
        {
            Assert.Throws<Exception>(() => list.DeleteLast());
        }


        [TestCaseSource(typeof(DeleteFirstTestSource))]
        public void DeleteFirstTest(LinkedList list, LinkedList expected_list)
        {
            list.DeleteFirst();
            Assert.AreEqual(expected_list, list);
        }

        [TestCaseSource(typeof(EmptyListTestSource))]
        public void DeleteFirstTest_WhenListIsEmpty_ShouldThrowException(LinkedList list)
        {
            Assert.Throws<Exception>(() => list.DeleteFirst());
        }


        [TestCaseSource(typeof(DeleteByIndexTestSource))]
        public void DeleteByIndexTest(int index, LinkedList list, LinkedList expected_list)
        {
            list.DeleteByIndex(index);
            Assert.AreEqual(expected_list, list);
        }

        [TestCaseSource(typeof(EmptyListWithIndexOrCountTestSource))]
        public void DeleteByIndexTest_WhenListIsEmpty_ShouldThrowException(int index, LinkedList list)
        {
            Assert.Throws<Exception>(() => list.DeleteByIndex(index));
        }

        [TestCaseSource(typeof(DeleteByIndexNegativeTestSource))]
        public void DeleteByIndexTest_WhenIndexIsWrong_ShouldThrowArgumentException(int index, LinkedList list)
        {
            Assert.Throws<ArgumentException>(() => list.DeleteByIndex(index));
        }


        [TestCaseSource(typeof(DeleteElementsAtTheEndTestSource))]
        public void DeleteElementsAtTheEndTest(int count, LinkedList list, LinkedList expected_list)
        {
            list.DeleteElementsAtTheEnd(count);
            Assert.AreEqual(expected_list, list);
        }

        [TestCaseSource(typeof(EmptyListWithIndexOrCountTestSource))]
        public void DeleteElementsAtTheEndTest_WhenListIsEmpty_ShouldThrowException(int count, LinkedList list)
        {
            Assert.Throws<Exception>(() => list.DeleteElementsAtTheEnd(count));
        }

        [TestCaseSource(typeof(WrongCountTestSource))]
        public void DeleteElementsAtTheEndTest_WhenCountIsWrong_ShouldThrowArgumentException(int count, LinkedList list)
        {
            Assert.Throws<ArgumentException>(() => list.DeleteElementsAtTheEnd(count));
        }




        [TestCaseSource(typeof(DeleteElementsAtBeginTestSource))]
        public void DeleteElementsAtBeginTest(int count, LinkedList list, LinkedList expected_list)
        {
            list.DeleteElementsAtBegin(count);
            Assert.AreEqual(expected_list, list);
        }

        [TestCaseSource(typeof(EmptyListWithIndexOrCountTestSource))]
        public void DeleteElementsAtBeginTest_WhenListIsEmpty_ShouldThrowException(int count, LinkedList list)
        {
            Assert.Throws<Exception>(() => list.DeleteElementsAtTheEnd(count));
        }

        [TestCaseSource(typeof(WrongCountTestSource))]
        public void DeleteElementsAtBeginTest_WhenCountIsWrong_ShouldThrowArgumentException(int count, LinkedList list)
        {
            Assert.Throws<ArgumentException>(() => list.DeleteElementsAtTheEnd(count));
        }




        [TestCaseSource(typeof(DeleteElementsByIndexTestSource))]
        public void DeleteElementsByindexTest(int count, int index, LinkedList list, LinkedList expected_list)
        {
            list.DeleteElementsByIndex(count, index);
            Assert.AreEqual(expected_list, list);
        }

        [TestCaseSource(typeof(DeleteElementsByIndexEmptyListTestSource))]
        public void DeleteElementsByIndexTest_WhenListIsEmpty_ShouldThrowException(int count, int index, LinkedList list)
        {
            Assert.Throws<Exception>(() => list.DeleteElementsByIndex(count, index));
        }

        [TestCaseSource(typeof(DeleteElementsByIndexWrongCountTestSource))]
        public void DeleteElementsByIndexTest_WhenCountIsWrong_ShouldThrowArgumentException(int count, int index, LinkedList list)
        {
            Assert.Throws<ArgumentException>(() => list.DeleteElementsByIndex(count, index));
        }

        [TestCaseSource(typeof(DeleteElementsByIndexWrongIndexTestSource))]
        public void DeleteElementsByIndexTest_WhenIndexIsWrong_ShouldThrowArgumentException(int count, int index, LinkedList list)
        {
            Assert.Throws<ArgumentException>(() => list.DeleteElementsByIndex(count, index));
        }

    }
}