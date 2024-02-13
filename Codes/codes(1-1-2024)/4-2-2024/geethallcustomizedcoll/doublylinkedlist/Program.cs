using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Geethall
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
        #region
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
        #endregion


        //To remove item which is present in the list
        #region
        public void RemoveNode(T data)
            {
                Node<T> current = head;
                while (current != null)
                {
                   
                    if(current.data.Equals(data))
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
        #endregion


        //To clear all the elements in the List 
        #region
        public void Clear()
        {
                head = tail = null;
                count = 0;
        }
        #endregion

        //To find Whether the list is empty or Not
        #region
        public bool IsEmpty()
         {
                if (head == null && tail == null)
                    return true;
                return false;
          }
        #endregion

        //To find item is present  at the List or Not
        #region
        public bool Contains(T data)
         {
                Node<T> current = head;

                while (current != null)
                {
                if (current.data.Equals(data))
                {
                        return true;

                }

                    current = current.next;

                }
                return false;




         }
        #endregion


        //To find Indexof certain item at the List
        #region
        public int IndexOf(T data)
            {
                Node<T> current = head;
                int index = 0;

                while (current != null)
                {
                     if (current.data.Equals(data))// This is used for checking equality condition between currentdata and data
                    {
                        return index;
                    }

                    current = current.next;
                    index++;
                }

                return -1; // Return -1 if the element is not found
            }
        #endregion
        //To count the noof elements in the list
        #region
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
        #endregion
        //To covert given list to  the array
        #region
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
        #endregion

        // To reverse the elements present in the list
        #region
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
        #endregion

        // To implement foreach loop we need getenumerator so we need to implement the Ienumerable interface which has this method and return type has Ienumerator
        #region
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
        #endregion
        //To print the elements in the list
        #region
        public void PrintList(geethall<int> dll)
        {
                foreach (int i in dll)
                {
                    Console.WriteLine(i + " " + "\n");
                }
        }
        #endregion





        }



        class Program
        {

            static void Main(string[] args)
            {
                geethall<int> dll = new geethall<int>();


                dll.AddNode(15);
                dll.AddNode(1);
                dll.AddNode(4);
                dll.AddNode(7);
                dll.AddNode(12);
                dll.PrintList(dll);
                dll.RemoveNode(4);
                dll.PrintList(dll);
                dll.AddNode(17);
                dll.PrintList(dll);
                bool b = dll.IsEmpty();
                Console.WriteLine($"list is Empty or not:{b}");
                bool c = dll.Contains(1);
                Console.WriteLine($"list Contains element or not:{c}");
                int d = dll.IndexOf(17);
                Console.WriteLine($"Print the index of specified element:{d}");
                Console.WriteLine($"count Noof elements in the given list:{dll.Count()}");
                 int[] e =dll.ToArray();
                Console.WriteLine($"convert the given list to array");
                  foreach (int i in e)
                  {
                    Console.WriteLine(i+ " ");
                  }

                dll.Reverse();
                Console.WriteLine($"Reverse the elements in the list");
                dll.PrintList(dll);
                Console.ReadLine();


            }
        }
    }
    