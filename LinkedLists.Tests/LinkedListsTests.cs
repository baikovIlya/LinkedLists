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


        [TestCaseSource(typeof(SearchIndexByValueTestSource))]
        public void SearchindexByValueTest(int value, LinkedList list, int expected_index)
        {
            int actual_index = list.SearchIndexByValue(value);
            Assert.AreEqual(expected_index, actual_index);
        }



        [TestCaseSource(typeof(GetMaxTestSource))]
        public void GetMaxTest(LinkedList list, int expected)
        {
            int actual = list.GetMax();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(EmptyListTestSource))]
        public void GetMaxTest_WhenListIsEmpty_ShouldThrowException(LinkedList list)
        {
            Assert.Throws<Exception>(() => list.GetMax());
        }


        [TestCaseSource(typeof(GetMinTestSource))]
        public void GetMinTest(LinkedList list, int expected)
        {
            int actual = list.GetMin();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(EmptyListTestSource))]
        public void GetMinTest_WhenListIsEmpty_ShouldThrowException(LinkedList list)
        {
            Assert.Throws<Exception>(() => list.GetMin());
        }

        [TestCaseSource(typeof(GetIndexOfMaxTestSource))]
        public void GetIndexOfMaxTest(LinkedList list, int expected)
        {
            int actual = list.GetIndexOfMax();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(EmptyListTestSource))]
        public void GetIndexOfMaxTest_WhenListIsEmpty_ShouldThrowException(LinkedList list)
        {
            Assert.Throws<Exception>(() => list.GetIndexOfMax());
        }

        [TestCaseSource(typeof(GetIndexOfMinTestSource))]
        public void GetIndexOfMinTest(LinkedList list, int expected)
        {
            int actual = list.GetIndexOfMin();
            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(EmptyListTestSource))]
        public void GetIndexOfMinTest_WhenListIsEmpty_ShouldThrowException(LinkedList list)
        {
            Assert.Throws<Exception>(() => list.GetIndexOfMin());
        }


        [TestCaseSource(typeof(DeleteByValueTestSource))]
        public void DeleteByValueTest(int value, int expected_index, LinkedList list, LinkedList expected_list)
        {
            int actual_index = list.DeleteFirstByValue(value);
            Assert.AreEqual(expected_index, actual_index);
            Assert.AreEqual(expected_list, list);
        }

        [TestCaseSource(typeof(EmptyListWithIndexOrCountTestSource))]
        public void DeleteByValueTest_WhenListIsEmpty_ShouldThrowException(int value, LinkedList list)
        {
            Assert.Throws<Exception>(() => list.DeleteFirstByValue(value));
        }

        [TestCaseSource(typeof(DeleteAllByValueTestSource))]
        public void DeleteAllByValueTest(int value, int expected_count, LinkedList list, LinkedList expected_list)
        {
            int actual_count = list.DeleteAllByValue(value);
            Assert.AreEqual(expected_count, actual_count);
            Assert.AreEqual(expected_list, list);
        }

        [TestCaseSource(typeof(EmptyListWithIndexOrCountTestSource))]
        public void DeleteAllByValueTest_WhenListIsEmpty_ShouldThrowException(int value, LinkedList list)
        {
            Assert.Throws<Exception>(() => list.DeleteAllByValue(value));
        }




        [TestCaseSource(typeof(AddListTestSource))]
        public void AddListTest(LinkedList list, LinkedList add_list, LinkedList expected_list)
        {
            list.AddList(add_list);
            Assert.AreEqual(list, expected_list);
        }

        [TestCaseSource(typeof(AddListAtBeginTestSource))]
        public void AddListAtBeginTest(LinkedList list, LinkedList add_list, LinkedList expected_list)
        {
            list.AddListAtBegin(add_list);
            Assert.AreEqual(list, expected_list);
        }




    }
}