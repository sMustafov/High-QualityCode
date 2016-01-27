using System;
using CustomLinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomLinkedListTest
{
    [TestClass]
    public class DynamicListUnitTest
    {
        public static DynamicList<string> DynamicList { get; set; }

        [ClassInitialize]
        public static void DynamicListTestsInitialize(TestContext testContext)
        {
            DynamicList = new DynamicList<string>();
        }

        [TestMethod]
        public void Count_TestCountOnNewListCreation_ShouldPassTest()
        {
            int initialCount = DynamicList.Count;

            Assert.AreEqual(0, initialCount, "A newly created list should have a count of 0.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Indexer_TestWithEmptyDynamicList_ShouldThrowArgumentOutOfRangeException()
        {
            string value = DynamicList[0];
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Indexer_TestWithNegativeIndex_ShouldThrowArgumentOutOfRangeException()
        {
            string value = DynamicList[-1];
        }

        [TestMethod]
        public void Indexer_TestWithValidIndex_ShouldPassTest()
        {
            DynamicList.Add("one");


            string value = DynamicList[0];
        }

        [TestMethod]
        public void Add_TestAddedElementValue_ShouldPassTest()
        {
            DynamicList.Add("one");

            string value = DynamicList[0];

            Assert.AreEqual("one", value, "The value at index 0 should be equal to the value entered.");
        }

        [TestMethod]
        public void Elements_TestPositionsOfElementsAddedInSequence_ShouldPassTest()
        {
            DynamicList.Add("first");
            DynamicList.Add("second");
            
            string firstElement = DynamicList[0];
            string secondElement = DynamicList[1];

            Assert.AreEqual("first",firstElement,"The element at index 0 should be the first element added to the list.");
            Assert.AreEqual("second",secondElement,"The element at index 1 should be the second element added to the list.");
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Set_TestAtNegativeIndex_ShouldThrowArgumentOutOfRangeException()
        {
            DynamicList[-1] = "one";
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Set_TestAtIndexBeyondListCount1_ShouldThrowArgumentOutOfRangeException()
        {
            DynamicList.Add("one");

            DynamicList[1] = "two";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Remove_TestAtNegativeIndex_ShouldThrowArgumentOutOfRangeException()
        {
            DynamicList.RemoveAt(-1);
        }
        
        [TestMethod]
        public void Count_TestListCountAfterRemoveAt_ShouldPassTest()
        {
            DynamicList.Add("one");
            DynamicList.RemoveAt(0);

            int count = DynamicList.Count;
            Assert.AreEqual(0, count);
        }

        [TestMethod]
        public void Count_TestAfterRemovingNonExistingElementFromList_ShouldPassTest()
        {
            DynamicList.Add("one");
            DynamicList.Add("two");

            DynamicList.Remove("three");

            int count = DynamicList.Count;

            Assert.AreEqual(2,count,"The count of the list should remain unchanged after trying to remove a non-existing element.");
        }

        [TestMethod]
        public void IndexOf_TestOnNonExistingElement_ShouldPassTest()
        {
            DynamicList.Add("first");
            DynamicList.Add("second");

            int index = DynamicList.IndexOf("third");

            Assert.AreEqual(-1, index, "The return value when searching for a non-existing element should be -1.");
        }
        
        [TestMethod]
        public void IndexOf_TestOnExistingElement_ShouldPassTest()
        {
            DynamicList.Add("first");
            DynamicList.Add("second");

            int index = DynamicList.IndexOf("second");

            Assert.AreEqual(1, index, "The index of the searched element should be 1.");
        }
    }
}
