using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListImplementation;

namespace LinkedListUnitTestProject
{
    [TestClass]
    public class LinkedListUnitTest
    {
        [TestMethod]
        public void DoesInsertFirstMethodAddElementToHeadOfListWhenListIsNotEmpty()
        {
            Node n1 = new Node() { Data = 1 };
            Node n2 = new Node() { Data = 2 };
            n1.Next = n2;
            n2.Next = null;
            

            LinkedList list = new LinkedList();
            list.Head = n1;
            list.Size = 2;

            list.InsertFirst(0);

            Assert.AreEqual(list.Size, 3);
            Assert.AreEqual(list.Head.Data, 0);
            Assert.AreEqual(list.Head.Next, n1);
            Assert.AreEqual(list.Head.Next.Next, n2);
            Assert.IsNull(list.Head.Next.Next.Next);
        }
    }
}
