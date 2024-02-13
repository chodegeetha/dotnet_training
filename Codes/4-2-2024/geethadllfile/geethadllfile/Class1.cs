using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geethadllfile
{
    public class Node<T>
    {
        #region
        public T data;
        public Node<T> previous;
        public Node<T> next;
        #endregion
        public Node(T value)
        {
            data = value;
        }
    }
    public class geethall<T> : IEnumerable<T>
    {
        #region
        public Node<T> head = null;
        public Node<T> tail = null;
        public int count = 0;
        #endregion

        //To add item to the current list
        public void AddNode(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                newNode.previous = tail;
                tail = newNode;
                tail.next = null;
            }
            count++;

        }


        //To remove item which is present in the list
        public void RemoveNode(T data)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.data, data))
                {
                    if (current.previous != null)
                    {
                        current.previous.next = current.next;
                    }
                    else
                    {
                        head = current.next;
                    }

                    if (current.next != null)
                    {
                        current.next.previous = current.previous;
                    }
                    else
                    {
                        tail = current.previous;
                    }


                    break;
                }

                current = current.next;
            }
            count--;
        }


        //To clear all the elements in the List 
        public void Clear()
        {
            head = tail = null;
            count = 0;
        }

        //To find Whether the list is empty or Not
        public bool IsEmpty()
        {
            if (head == null && tail == null)
                return true;
            return false;
        }

        //To find item is present  at the List or Not
        public bool Contains(T data)
        {
            Node<T> current = head;

            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.data, data))
                {
                    return true;

                }

                current = current.next;

            }
            return false;




        }


        //To find Indexof certain item at the List
        public int IndexOf(T data)
        {
            Node<T> current = head;
            int index = 0;

            while (current != null)
            {
                if (EqualityComparer<T>.Default.Equals(current.data, data))// This is used for checking equality condition between currentdata and data
                {
                    return index;
                }

                current = current.next;
                index++;
            }

            return -1; // Return -1 if the element is not found
        }
        //To count the noof elements in the list
        public int Count()
        {
            count = 0;
            Node<T> current = head;

            while (current != null)
            {
                count++;
                current = current.next;
            }

            return count;
        }

        //To covert given list to  the array

        public T[] ToArray()
        {
            T[] arr = new T[count]; // count track the length of elements
            Node<T> current = head;

            for (int i = 0; i < count && current != null; i++)
            {
                arr[i] = current.data;
                current = current.next;
            }

            return arr;
        }

        // To reverse the elements present in the list
        public void Reverse()
        {
            Node<T> current = head;
            Node<T> temp = null;

            // Swap head and tail pointers for reversing
            temp = head;
            head = tail;
            tail = temp;


            while (current != null)
            {
                temp = current.next;
                current.next = current.previous;
                current.previous = temp;

                current = temp;
            }
        }

        // To implement foreach loop we need getenumerator so we need to implement the Ienumerable interface which has this method and return type has Ienumerator
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;

            while (current != null)
            {
                yield return current.data;
                current = current.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //To print the elements in the list
        public void PrintList(geethall<int> dll)
        {
            foreach (int i in dll)
            {
                Console.WriteLine(i + " " + "\n");
            }
        }





    }



}
