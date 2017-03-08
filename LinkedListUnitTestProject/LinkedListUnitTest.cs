using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedListImplementation;

namespace LinkedListUnitTestProject
{
    [TestClass]
    public class LinkedListUnitTest
    {
        [TestMethod]
        public void DoesDisplayElementsMethodShowElementsOfListCorrectlyWhenListIsNotEmpty()
        {
            Node n1 = new Node() { Data = 1 };
            Node n2 = new Node() { Data = 2 };
            n1.Next = n2;
            n2.Next = null;

            LinkedList list = new LinkedList();
            list.Head = n1;
            list.Size = 2;

            string expectedResult = "1 2 ";
            string actualResult = list.DisplayElements();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DoesDisplayElementsMethodShowElementsOfListCorrectlyWhenListIsEmpty()
        {
            LinkedList list = new LinkedList();
            string expectedResult = "";
            string actualResult = list.DisplayElements();

            Assert.AreEqual(expectedResult, actualResult);
        }

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

            string expectedResult = "0 1 2 ";
            string actualResult = list.DisplayElements();
            Assert.AreEqual(expectedResult, actualResult);

            Assert.IsNull(list.Head.Next.Next.Next);
        }

        [TestMethod]
        public void DoesInsertFirstMethodAddElementToHeadOfListWhenListIsEmpty()
        {
            LinkedList list = new LinkedList();
            list.InsertFirst(0);

            Assert.AreEqual(list.Size, 1);

            string expectedResult = "0 ";
            string actualResult = list.DisplayElements();
            Assert.AreEqual(expectedResult, actualResult);

            Assert.IsNull(list.Head.Next);
        }

        [TestMethod]
        public void DoesInsertLastMethodAddElementToEndOfListWhenListIsNotEmpty()
        {
            Node n1 = new Node() { Data = 1 };
            Node n2 = new Node() { Data = 2 };
            n1.Next = n2;
            n2.Next = null;

            LinkedList list = new LinkedList();
            list.Head = n1;
            list.Size = 2;

            list.InsertLast(3);
            Assert.AreEqual(list.Size, 3);

            string expectedResult = "1 2 3 ";
            string actualResult = list.DisplayElements();
            Assert.AreEqual(expectedResult, actualResult);

            Assert.IsNull(list.Head.Next.Next.Next);

        }

        [TestMethod]
        public void DoesInsertLastMethodAddElementToEndOfListWhenListIsEmpty()
        {
            LinkedList list = new LinkedList();

            list.InsertLast(3);
            Assert.AreEqual(list.Size, 1);

            string expectedResult = "3 ";
            string actualResult = list.DisplayElements();
            Assert.AreEqual(expectedResult, actualResult);

            Assert.IsNull(list.Head.Next);

        }

        [TestMethod]
        public void DoesInsertPosMethodAddElementAtDesiredPositionOfListWhenListIsEmpty()
        {
            Node n1 = new Node() { Data = 1 };
            Node n2 = new Node() { Data = 2 };
            n1.Next = n2;
            n2.Next = null;

            LinkedList list = new LinkedList();
            list.Head = n1;
            list.Size = 2;

            list.InsertPos(1, 15);
            Assert.AreEqual(list.Size, 3);

            string expectedResult = "1 15 2 ";
            string actualResult = list.DisplayElements();
            Assert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        public void DoesInsertPosMethodAddElementAtZerothPositionOfListWhenListIsNotEmpty()
        {
            Node n1 = new Node() { Data = 1 };
            Node n2 = new Node() { Data = 2 };
            n1.Next = n2;
            n2.Next = null;

            LinkedList list = new LinkedList();
            list.Head = n1;
            list.Size = 2;

            list.InsertPos(0, 10);
            Assert.AreEqual(list.Size, 3);

            string expectedResult = "10 1 2 ";
            string actualResult = list.DisplayElements();
            Assert.AreEqual(expectedResult, actualResult);

        }


        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void DoesInsertPosMethodThrowErrorWhenNegativePositionPassed()
        {
            LinkedList list = new LinkedList();
            list.InsertPos(-3, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void DoesInsertPosMethodThrowErrorWhenPositionValueIsLargerThanSizeAndListIsNotEmpty()
        {
            Node n1 = new Node() { Data = 1 };
            Node n2 = new Node() { Data = 2 };
            n1.Next = n2;
            n2.Next = null;

            LinkedList list = new LinkedList();
            list.Head = n1;
            list.Size = 2;

            list.InsertPos(3, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void DoesInsertPosMethodThrowErrorWhenPositionLargerThanSizeAndListIsEmpty()
        {
            LinkedList list = new LinkedList();
            list.InsertPos(5, 10);
        }

    }
}
