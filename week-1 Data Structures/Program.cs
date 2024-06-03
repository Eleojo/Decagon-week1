using System;
namespace week_1_Data_Structures
{
    internal class Program
    {
        // LINKED LIST IMPLEMENTATION
        public class Node<T>
        {
            public T Data { get; set; }
            public Node<T> Next { get; set; }

            public Node(T data)
            {
                this.Data = data;
                this.Next = null;
            }
        }

        public class LinkedList<T>
        {
            private int counter { get; set; }
            private Node<T> head { get; set; }

            public LinkedList()
            {
                this.head = null;
                this.counter = 0;
            }

            public void Add(T data)
            {
                Node<T> newNode = new Node<T>(data);

                if (head == null)
                {
                    head = newNode;
                }
                else
                {
                    Node<T> current = head;
                    while (current.Next != null)
                    {
                        current = current.Next;
                    }
                    current.Next = newNode;

                }

            }
            public void Remove(T data)
            {
                if (head == null) return;
                if (head.Data.Equals(data))
                {
                    head = head.Next;
                    return;

                }
                Node<T> current = head;
                while (current.Next != null && !current.Next.Data.Equals(data))
                {
                    current = current.Next;
                }
                if (current.Next != null)
                {
                    current.Next = current.Next.Next;
                }

            }
            public bool Check(T data)
            {

                Node<T> current = head;

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        return true;

                    }

                    current = current.Next;
                    counter++;
                }
                return false;


            }

            public int ItemIndex(T data)
            {
                Node<T> current = head;
                int index = 0;
                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        Console.WriteLine($"{data} is at index {index}");
                        return index;

                    }
                    current = current.Next;
                    index++;
                }

                return -1;

            }


            public void PrintList()
            {
                Node<T> current = head;
                while (current != null)
                {
                    Console.Write(current.Data + "-> ");
                    current = current.Next;
                }

                Console.WriteLine("null");
            }

        }


        // STACK IMPLEMENTATION USING LINKED LIST

        public class Stack<T>
        {
            public class Node<T>
            {

                public T Data { get; set; }
                public Node<T> Next { get; set; }


                public Node(T data)
                {
                    this.Data = data;
                    this.Next = null;

                }
            }

            Node<T> top;
            public int Count { get; set; }

            public Stack()
            {
                top = null;
                this.Count = 0;

            }
            public bool IsEmpty() => top == null;
            public void Push(T data)
            {
                Node<T> newNode = new Node<T>(data);
                newNode.Next = top;
                top = newNode;
                Count++;

            }
            public T Pop()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("Stack is Empty");
                }

                T item = top.Data;
                top = top.Next;
                Count--;
                return item;
            }

            public T Peak()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("Stack is Empty");
                }
                return top.Data;
            }

            public int Size()
            {
                Console.WriteLine($"The Stack has {Count} values");
                return Count;
            }

        }

        public class Queue<T>
        {
            public class Node<T>
            {
                public T Data { get; set; }
                public Node<T> Next { get; set; }
                public Node(T data)
                {
                    this.Data = data;
                    this.Next = null;
                }
            }
        }




            static void Main(string[] args)
            {
                //Code to run the linked list
                LinkedList<int> list = new LinkedList<int>();
                list.Add(1);
                list.Add(2);
                list.Add(3);
                list.Add(5);
                list.PrintList(); // Output: 1 -> 2 -> 3 -> null

                list.Remove(3);
                list.PrintList(); // Output: 1 -> 3 -> null
                Console.WriteLine(list.Check(3));
                list.ItemIndex(1);
                list.ItemIndex(2);
                list.ItemIndex(3);
                list.ItemIndex(5);


                //Code to Run the Stack
                //    Stack<int> stack = new Stack<int>();
                //stack.Push(1);
                //stack.Push(2);
                //stack.Push(5);
                //Console.WriteLine($"The Peak is {stack.Peak()}");
                //stack.Size();


            }

        }
    
}

