﻿using System;
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
            Node n1 = new Node() { Data = 34 };
            Node n2 = new Node() { Data = 11 };
            Node n3 = new Node() { Data = 142 };
            n1.Next = n2;
            n2.Next = n3;
            n3.Next = null;

            LinkedList list = new LinkedList();
            list.Head = n1;
            list.Size = 3;

            list.InsertPos(2, 122);
            Assert.AreEqual(4, list.Size);

            string expectedResult = "34 11 122 142 ";
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

        [TestMethod]
        public void HasGetElementMethodRetrievedTheExpectedNodeWhenListIsNotEmpty()
        {
            Node n1 = new Node() { Data = 34 };
            Node n2 = new Node() { Data = 11 };
            Node n3 = new Node() { Data = 142 };
            n1.Next = n2;
            n2.Next = n3;
            n3.Next = null;

            LinkedList list = new LinkedList();
            list.Head = n1;
            list.Size = 3;

            Node expected = n3;
            Node actualResult = list.GetElement(2);
            Assert.AreEqual(expected.Data, actualResult.Data);
            Assert.AreEqual(list.Size, 3);

            expected = n1;
            actualResult = list.GetElement(0);
            Assert.AreEqual(expected.Data, actualResult.Data);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void DoesGetElementMethodThrowErrorWhenListIsEmpty()
        {
            LinkedList list = new LinkedList();
            list.GetElement(0);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void DoesGetElementMethodThrowErrorWhenPositionIsLargerThanSizeAndListIsNotEmpty()
        {
            Node n1 = new Node() { Data = 1 };
            Node n2 = new Node() { Data = 2 };
            n1.Next = n2;
            n2.Next = null;

            LinkedList list = new LinkedList();
            list.Head = n1;
            list.Size = 2;

            list.GetElement(2);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void DoesGetElementMethodThrowErrorWhenPositionIsNegative()
        {
            LinkedList list = new LinkedList();
            list.GetElement(-5);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void DoesDeleteFirstMethodDeleteTheBeginningElementofListWhenListIsEmpty()
        {
            LinkedList list = new LinkedList();
            list.DeleteFirst();
            Assert.AreEqual(0, list.Size);
        }

        [TestMethod]
        public void DoesDeleteFirstMethodDeleteTheBeginningElementofListWhenListIsNotEmpty()
        {
            Node n1 = new Node() { Data = 34 };
            Node n2 = new Node() { Data = 11 };
            Node n3 = new Node() { Data = 142 };
            n1.Next = n2;
            n2.Next = n3;
            n3.Next = null;

            LinkedList list = new LinkedList();
            list.Head = n1;
            list.Size = 3;

            list.DeleteFirst();
            Assert.AreEqual(2, list.Size);

            string expectedResult = "11 142 ";
            string actualResult = list.DisplayElements();
            Assert.AreEqual(expectedResult, actualResult);
        }


        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void DoesDeleteLastMethodDeleteTheLastElementinListWhenListIsEmpty()
        {
            LinkedList list = new LinkedList();
            list.DeleteLast();
            Assert.AreEqual(0, list.Size);
        }

        [TestMethod]
        public void DoesDeleteLastMethodDeleteTheLastElementinListWhenListIsNotEmpty()
        {
            Node n1 = new Node() { Data = 34 };
            Node n2 = new Node() { Data = 11 };
            Node n3 = new Node() { Data = 142 };
            n1.Next = n2;
            n2.Next = n3;
            n3.Next = null;

            LinkedList list = new LinkedList();
            list.Head = n1;
            list.Size = 3;

            list.DeleteLast();
            Assert.AreEqual(2, list.Size);

            string expectedResult = "34 11 ";
            string actualResult = list.DisplayElements();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DoesDeleteLastMethodDeleteTheLastElementinListWhenListHasOneElement()
        {
            Node n1 = new Node() { Data = 34 };
            n1.Next = null;

            LinkedList list = new LinkedList();
            list.Head = n1;
            list.Size = 1;

            list.DeleteLast();
            Assert.AreEqual(0, list.Size);

            string expectedResult = "";
            string actualResult = list.DisplayElements();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DoesDeletePosMethodDeleteTheDesiredElementinListWhenListIsNotEmpty()
        {
            Node n4 = new Node() { Data = 142, Next = null };
            Node n3 = new Node() { Data = 122, Next = n4 };
            Node n2 = new Node() { Data = 11, Next = n3 };
            Node n1 = new Node() { Data = 34, Next = n2 };

            LinkedList list = new LinkedList() { Head = n1, Size = 4 };

            list.DeletePos(2);
            Assert.AreEqual(3, list.Size);

            string expectedResult = "34 11 142 ";
            string actualResult = list.DisplayElements();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DoesDeletePosMethodDeleteTheZerothElementinListWhenListHasOneElement()
        {
            Node n1 = new Node() { Data = 34, Next = null };
            LinkedList list = new LinkedList() { Head = n1, Size = 1 };

            list.DeletePos(0);
            Assert.AreEqual(0, list.Size);

            string expectedResult = "";
            string actualResult = list.DisplayElements();
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void DoesDeletePosMethodThrowErrorWhenListIsEmpty()
        {
            LinkedList list = new LinkedList();
            list.DeletePos(0);
            Assert.AreEqual(0, list.Size);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void DoesDeletePosMethodThrowErrorWhenPositionIsNegative()
        {
            Node n1 = new Node() { Data = 10 };
            n1.Next = null;
            LinkedList list = new LinkedList() { Head = n1, Size = 1 };
            list.DeletePos(-2);
            Assert.AreEqual(1, list.Size);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void DoesDeletePosMethodThrowErrorWhenPositionIsLargerThanSize()
        {
            Node n1 = new Node() { Data = 10 };
            n1.Next = null;
            LinkedList list = new LinkedList() { Head = n1, Size = 1 };
            list.DeletePos(1);
            Assert.AreEqual(0, list.Size);
        }

        [TestMethod]
        public void TestingWithMultipleOperations()
        {
            LinkedList list = new LinkedList();
            list.InsertFirst(4);
            list.InsertLast(5);
            string expected = "4 5 ";
            string actual = list.DisplayElements();
            Assert.AreEqual(expected, actual);

            list.InsertFirst(1);
            list.InsertFirst(2);
            list.InsertFirst(8);
            expected = "8 2 1 4 5 ";
            actual = list.DisplayElements();
            Assert.AreEqual(expected, actual);

            list.DeleteFirst();
            expected = "2 1 4 5 ";
            actual = list.DisplayElements();
            Assert.AreEqual(expected, actual);

            list.DeleteLast();
            expected = "2 1 4 ";
            actual = list.DisplayElements();
            Assert.AreEqual(expected, actual);

            list.DeleteLast();
            list.DeleteLast();
            expected = "2 ";
            actual = list.DisplayElements();
            Assert.AreEqual(expected, actual);
        }

       
    }
}
