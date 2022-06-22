using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{

    public class LinkedList
    {

        internal class Node
        {

            internal int _value;
            internal Node _next;

            public Node(int value)
            {
                _value = value;
                _next = null;
            }

            public Node(int value, Node next) : this(value)
            {
                _next = next;
            }

            public int GetValue()
            { return _value; }

            public Node GetNext()
            { return _next; }
        }

        private Node _head;
        private Node _tail;

        public LinkedList()
        {
        }

        public int GetHead()
        { return _head.GetValue(); }

        public int GetTail()
        { return _tail.GetValue(); }

        public void AddFirst(int val)
        {
            Node newNode = new Node(val, this._head);
            _head = newNode;
            if (newNode._next == null)
            {
                _tail = newNode;
            }
        }

        public void AddLast(int val)
        {
            if (_head == null)
            {
                AddFirst(val);
                return;
            }

            Node curr = this._head;
            while (curr.GetNext() != null)
            {
                curr = curr.GetNext();
            }

            curr._next = new Node(val);
            _tail = curr._next;
        }

        public void RemoveFirst()
        {
            Node curr = this._head;
            this._head = curr._next;
        }



        public int Size()
        {
            if (_head == null)
            {
                return 0;
            }

            else
            {
                int Counter = 0;
                Node curr = this._head;
                while (curr != null)
                {
                    Counter++;
                    curr = curr._next;
                }
                return Counter;
            }
        }

        public void Reverse()
        {
            Node curr = this._head;
            Node prev = null;
            this._tail = curr;
            while (curr._next != null)
            {
                Node next = curr._next;
                curr._next = prev;
                prev = curr;
                curr = next;
            }
            curr._next = prev;
            this._head = curr;
        }

        public void Print()
        {
            Node curr = this._head;
            while (curr != null)
            {
                Console.Write(curr.GetValue() + ", ");
                curr = curr.GetNext();
            }
        }
    }
}
