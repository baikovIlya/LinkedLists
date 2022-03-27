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

    }
}