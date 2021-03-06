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

        public void Reverse()
        {
            if (Length > 1)
            {
                Node crnt = _root;
                Node rev;
                while (crnt.Next != null)
                {
                    rev = crnt.Next;
                    crnt.Next = rev.Next;
                    rev.Next = _root;
                    _root = rev;
                }
            }
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

        public int GetIndexOfMax()
        {
            if (Length < 1)
            {
                throw new Exception("There are no items to search for");
            }
            int max = _root.Value;
            int index = 0;
            int index_of_max = 0;
            Node crnt = _root;
            while (crnt != null)
            {
                if (crnt.Value > max)
                {
                    max = crnt.Value;
                    index_of_max = index;
                }
                index++;
                crnt = crnt.Next;
            }
            return index_of_max;

        }

        public int GetIndexOfMin()
        {
            if (Length < 1)
            {
                throw new Exception("There are no items to search for");
            }
            int min = _root.Value;
            int index = 0;
            int index_of_min = 0;
            Node crnt = _root;
            while (crnt != null)
            {
                if (crnt.Value < min)
                {
                    min = crnt.Value;
                    index_of_min = index;
                }
                index++;
                crnt = crnt.Next;
            }
            return index_of_min;

        }

        public void SortAscending()
        {
            if (Length > 1)
            {
                int l = Length;
                Node crnt;
                Node prev;

                for (int i = l - 2; i >= 0; i--)
                {
                    if (i == 0)
                    {
                        crnt = _root;
                        if (crnt.Next != null && crnt.Value > crnt.Next.Value)
                        {
                            _root = crnt.Next;
                            crnt.Next = _root.Next;
                            _root.Next = crnt;
                        }
                        prev = _root;
                    }
                    else
                    {
                        prev = GetNode(i - 1);
                        crnt = prev.Next;
                    }

                    while (crnt.Next != null && crnt.Value > crnt.Next.Value)
                    {
                        prev.Next = crnt.Next;
                        crnt.Next = prev.Next.Next;
                        prev.Next.Next = crnt;

                        prev = prev.Next;
                    }
                }

                _tail = GetTail();
            }
        }

        public void SortDescending()
        {
            this.SortAscending();
            this.Reverse();
        }

        public int DeleteFirstByValue(int value)
        {
            if (Length < 1)
            {
                throw new Exception("There are no items to delete");
            }
            int index = -1;
            if (_root.Value == value)
            {
                _root = _root.Next;
                index = 0;
            }
            else
            {
                Node crnt = _root.Next;

                for (int i = 1; i < Length; i++)
                {
                    if (crnt.Value == value)
                    {
                        index = i;
                        Node left_node = GetNode(index - 1);
                        left_node.Next = crnt.Next;
                        break;
                    }
                    crnt = crnt.Next;
                }
            }
            _tail = GetTail();
            return index;
        }

        public int DeleteAllByValue(int value)
        {
            if (Length < 1)
            {
                throw new Exception("There are no items to delete");
            }
            Node crnt = _root;
            int index = 0;
            int result = 0;
            while (crnt != null)
            {
                if (crnt.Value == value)
                {
                    if (index == 0)
                    {
                        _root = crnt.Next;
                        result++;
                        index--;
                    }
                    else
                    {
                        Node previous = GetNode(index - 1);
                        previous.Next = crnt.Next;
                        result++;
                        index--;
                    }
                }
                index++;
                crnt = crnt.Next;
            }
            _tail = GetTail();
            return result;
        }

        public void AddList(LinkedList second_list)
        {
            if (_root == null)
            {
                this._root = second_list._root;
            }
            else
            {
                _tail = GetTail();
                _tail.Next = second_list._root;
                _tail = GetTail();
            }
        }

        public void AddListAtBegin(LinkedList add_list)
        {
            if (add_list._root != null)
            {
                Node tmp = this._root;
                add_list._tail.Next = tmp;
                this._root = add_list._root;
            }
        }

        public void AddListByIndex(int index, LinkedList add_list)
        {
            if (index < 0 || index > Length)
            {
                throw new ArgumentException("This index doesn't exist");
            }
            if (this._root == null && index == 0)
            {
                this._root = add_list._root;
            }
            else if (index == 0)
            {
                this.AddListAtBegin(add_list);
            }
            else if (add_list._root != null)
            {
                Node left = GetNode(index-1);
                Node right = GetNode(index);
                left.Next = add_list._root;
                add_list._tail=add_list.GetTail();
                add_list._tail.Next = right;
            }
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
            for (int i = 1; i < this.Length; i++)
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
