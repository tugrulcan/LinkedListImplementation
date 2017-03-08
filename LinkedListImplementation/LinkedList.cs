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
            throw new NotImplementedException();
        }

        public override void DeleteLast()
        {
            throw new NotImplementedException();
        }

        public override void DeletePos(int position)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
            else if (position == 0)
            {
                this.InsertFirst(value);
            }
            else
            {
                Node newNode = new Node() { Data = value };

                Node currentNode = this.Head;
                
                for (int counter = 0; counter +1 < position ; counter++)
                {
                    currentNode = currentNode.Next;
                }

                newNode.Next = currentNode.Next;
                currentNode.Next = newNode;
                this.Size++;
            }
        }
    }
}
