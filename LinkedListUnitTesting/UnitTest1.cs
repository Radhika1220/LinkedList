using LinkedListUsingGenerics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LinkedListUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        CustomLinkedList list = new CustomLinkedList();
       
        [TestMethod]
     

        public void TestSearchAndInsertMethod()
        {
            list.InsertLast(56);
            list.InsertLast(30);
            list.InsertLast(70);
            int actual = list.InsertBetween(30, 40);
            int expected = 40;
            Assert.AreEqual(expected, actual);

        }
    }
}
