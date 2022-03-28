using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    public class LinkedList
    {
        private Node _root;

        private Node _tail;

        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException("This index doesn't exist");
                }
                Node crnt = _root;
                for (int i = 1; i <= index; i++)
                {
                    crnt = crnt.Next;
                }

                return crnt.Value;
            }

            set
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException("This index doesn't exist");
                }
                Node crnt = _root;
                for (int i = 1; i <= index; i++)
                {
                    crnt = crnt.Next;
                }
                crnt.Value = value;
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

        public LinkedList(int[] array)
        {
            if (array.Length == 0)
            {
                _root = null;
                _tail = null;
            }
            else
            {
                _root = new Node(array[0]);
                Node crnt = _root;
                for (int i =1; i<array.Length; i++)
                {
                    crnt.Next = new Node(array[i]);
                    crnt = crnt.Next;
                }
                _tail = crnt;
            }
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

                _tail.Next = new Node(value);
                _tail = _tail.Next;
            }
        }

        public void AddFirst(int value)
        {
            if (_root is null)
            {
                _root = new Node(value);
                _tail = _root;
            }
            else
            {
                Node crnt = _root;
                _root = new Node(value);
                _root.Next = crnt;
            }
        }
        public void AddByIndex(int value, int index)
        {
            if (index < 0 || index >= Length+1)
            {
                throw new ArgumentException("This index doesn't exist");
            }
            if (index == 0)
            {
                AddFirst(value);
            }
            else
            {
                Node prevNode = GetNode(index - 1);
                Node nextNode = GetNode(index);
                Node newNode = new Node(value);
                prevNode.Next = newNode;
                newNode.Next = nextNode;
            }
        }

        public void DeleteLast()
        {
            if (Length < 1)
            {
                throw new Exception("there is nothing to delete here");
            }
            if (Length == 1)
            {
                _root = null;
                _tail = null;
            }
            else
            {
                Node last_node = GetNode(Length - 2);
                last_node.Next = null;
                _tail = last_node;
            }
        }

        public void DeleteFirst()
        {
            if (Length < 1)
            {
                throw new Exception("there is nothing to delete here");
            }
            _root = _root.Next;
        }

        public void DeleteByIndex(int index)
        {
            if (_tail is null)
            {
                throw new Exception("There is nothing to delete here");
            }
            if (index < 0 || index >= Length)
            {
                throw new ArgumentException("This index doesn'n exist");
            }
            if (index == 0)
            {
                _root = _root.Next;
            }
            else
            {
                Node left_node = GetNode(index - 1);
                Node right_node = GetNode(index + 1);
                left_node.Next = right_node;
            }
            _tail = GetTail();
        }

        public void DeleteElementsAtTheEnd(int count)
        {
            if (Length <1)
            {
                throw new Exception("There is nothing to delete here");
            }
            else if (count < 1 || count > Length)
            {
                throw new ArgumentException("Incorrect nomber");
            }
            else if (Length == count)
            {
                _root = null;
                _tail = null;
            }
            else 
            {
                Node new_last_node = GetNode(Length-count-1);
                new_last_node.Next = null;
                _tail = new_last_node;
            }
        }

        public void DeleteElementsAtBegin(int count)
        {
            if (Length < 1)
            {
                throw new Exception("There is nothing to delete here");
            }
            else if (count < 1 || count > Length)
            {
                throw new ArgumentException("Incorrect nomber");
            }
            else if (Length == count)
            {
                _root = null;
                _tail = null;
            }
            else
            {
                Node new_first_node = GetNode(count);
                _root = new_first_node;
            }
        }

        public void DeleteElementsByIndex(int count, int index)
        {
            if (Length < 1)
            {
                throw new Exception("There is nothing to delete here");
            }
            else if (count < 1 || count > Length || (Length - index) < count)
            {
                throw new ArgumentException("Incorrect count");
            }
            if (index < 0 || index >= Length)
            {
                throw new ArgumentException("This index doesn't exist");
            }
            Node left = GetNode(index-1);
            Node right = GetNode(index+count);
            if (index == 0)
            {
                _root = right;
            }
            else
            {
                left.Next = right;
            }
            _tail = GetTail();
        }

        public int SearchIndexByValue(int value)
        {
            int index = -1;
            Node crnt = _root;
            for (int i=0; i<Length; i++)
            {
                if(crnt.Value == value)
                {
                    index = i;
                    break;
                }
                crnt = crnt.Next;
            }
            return index;
        }

        public int GetMax()
        {
            if (Length < 1)
            {
                throw new Exception("There are no items to search for");
            }
            int max = _root.Value;
            Node crnt = _root;
            while(crnt != null)
            {
                if (crnt.Value > max)
                {
                    max = crnt.Value;
                }
                crnt = crnt.Next;
            }
            return max;
        }

        public int GetMin()
        {
            if (Length < 1)
            {
                throw new Exception("There are no items to search for");
            }
            int min = _root.Value;
            Node crnt = _root;
            while (crnt != null)
            {
                if (crnt.Value < min)
                {
                    min = crnt.Value;
                }
                crnt = crnt.Next;
            }
            return min;
        }













        public override string ToString()
        {
            string str = "{ ";
            Node crnt = _root;
            while (crnt != null)
            {
                str += $"{crnt.Value} ";
                crnt = crnt.Next;
            }
            str += "}";
            return str;
        }

        public override bool Equals(object? obj)
        {
            bool rez = true;
            if (obj == null || !(obj is LinkedList))
            {
                rez = false;
            }

            LinkedList list = (LinkedList)obj;

            if (list.Length != this.Length)
            {
                rez = false;
            }
            Node crnt = _root;
            Node crnt_equal = list._root;
            while (crnt != null)
            {
                if (crnt.Value != crnt_equal.Value)
                {
                    rez = false;
                }
                crnt = crnt.Next;
                crnt_equal = crnt_equal.Next;
            }

            return rez;
        }


        private Node GetTail()
        {
            Node crnt = _root;
            for (int i = 1; i <= this.Length; i++)
            {
                crnt = crnt.Next;
            }
            return crnt;

        }
        private Node GetNode(int index)
        {
            Node crnt = _root;
            for (int i = 1; i <= index; i++)
            {
                crnt = crnt.Next;
            }
            return crnt;
        }
    }

}
