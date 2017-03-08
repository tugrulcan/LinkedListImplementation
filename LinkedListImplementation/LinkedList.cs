using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListImplementation
{
    public class LinkedList : LinkedListADT
    {
        public override void DeleteFirst()
        {
            if (this.Head == null)
                throw new IndexOutOfRangeException();
            else
            {
                this.Head = this.Head.Next;
                this.Size--;
            }
        }

        public override void DeleteLast()
        {
            if (this.Head == null)
                throw new IndexOutOfRangeException();
            else if (this.Head.Next == null)
            {
                this.DeleteFirst();
            }
            else
            {
                Node currentNode = this.Head;
                Node lastPrevious = this.Head; 
                while (currentNode.Next != null)
                {
                    lastPrevious = currentNode;
                    currentNode = currentNode.Next;
                }

                lastPrevious.Next = null;
                currentNode = null;
                this.Size--;
            }
        }

        public override void DeletePos(int position)
        {
            if (position<0 || position +1 > this.Size || this.Head == null)
            {
                throw new IndexOutOfRangeException();
            }
            else if (position == 0)
            {
                this.DeleteFirst();
            }
            else
            {
                Node currentNode = this.Head;
                Node lastPreviousNode = null;
                for (int counter = 0; counter < position; counter++)
                {
                    lastPreviousNode = currentNode;
                    currentNode = currentNode.Next;
                }
                lastPreviousNode.Next = currentNode.Next;
                this.Size--;
            }
        }

        public override string DisplayElements()
        {
            string result = "";

            Node tmpCurrentNode = Head;
            while (tmpCurrentNode != null)
            {
                result += tmpCurrentNode.Data.ToString() + " ";
                tmpCurrentNode = tmpCurrentNode.Next;
            }


            return result;
        }

        public override Node GetElement(int position)
        {
            if (position < 0 || position + 1 > this.Size)
            {
                throw new IndexOutOfRangeException();
            }
            else if (this.Head == null)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                Node currentNode = this.Head;
                for (int counter = 0; counter < position; counter++)
                {
                    currentNode = currentNode.Next;
                }
                return currentNode;
            }
        }


        public override void InsertFirst(int value)
        {
            Node newHead = new Node() { Data = value };
            Node tmpHead = this.Head;
            newHead.Next = this.Head;
            this.Head = newHead;
            this.Size++;

        }

        public override void InsertLast(int value)
        {
            if (this.Head == null)
            {
                this.InsertFirst(value);
            }
            else
            {
                Node newLast = new Node() { Data = value };
                Node currentNode = this.Head;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Next = newLast;
                Size++;
            }

        }

        public override void InsertPos(int position, int value)
        {
            if (position < 0 || position + 1 > this.Size)
            {
                throw new IndexOutOfRangeException();
            }
            else if (position == 0 || this.Head == null)
            {
                this.InsertFirst(value);
            }
            else
            {
                Node newNode = new Node() { Data = value };

                Node currentNode = this.Head;
                Node lastPreviousNode = this.Head;
                for (int counter = 0; counter < position; counter++)
                {
                    lastPreviousNode = currentNode;
                    currentNode = currentNode.Next;
                }

                newNode.Next = currentNode;
                lastPreviousNode.Next = newNode;
                this.Size++;
            }

            #region Çalışan ama ilk elemanı değiştirmeyen kod bloğu

            //Node newNode = new Node { Data = value };
            //if (this.Head == null)
            //{
            //    this.InsertFirst(value);
            //}

            //Node posNode = this.Head;
            ////counter 1'den mi başlamalı? 
            //for (int counter = 1; counter < position; counter++)
            //{
            //    posNode = posNode.Next;
            //}

            //Node tempNext = posNode.Next;
            //posNode.Next = newNode;
            //newNode.Next = tempNext;
            //this.Size++;

            #endregion

        }
    }
}
