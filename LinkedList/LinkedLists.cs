using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
        public class LinkedList
        {
            private Node _root;

            private Node _tail;

            public int this[int index]
            {
                get
                {
                    Node crnt = _root;
                    for (int i = 1; i <= index; i++)
                    {
                        crnt = crnt.Next;
                    }

                    return crnt.Value;
                }

                set
                {

                }
            }

            public int Length
            {
                get
                {
                    int count = 0;
                    Node crnt = _root;

                    while (crnt != null)
                    {
                        crnt = crnt.Next;
                        count++;
                    }

                    return count;
                }
                private set
                {
                }
            }

            public LinkedList()
            {
                _root = null;

                _tail = null;
            }

            public LinkedList(int value)
            {
                _root = new Node(value);
                _tail = _root;
            }

            public void Add(int value)
            {
                if (_root == null)
                {
                    _root = new Node(value);
                    _tail = _root;
                }
                else
                {
                    //Node crnt = _root;

                    //while (crnt.Next != null)
                    //{
                    //    crnt = crnt.Next;
                    //}

                    //crnt.Next = new Node(value);

                    _tail.Next = new Node(value);
                    _tail = _tail.Next;
                }
            }
        }

}
