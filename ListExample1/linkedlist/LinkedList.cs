using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample1.linkedlist
{
    internal class LinkedList
    {
            private Node head;
            private Node tail;
            private int size;

         
            public void AddAtTail(string data)
            {
                Node node = new Node(data);

                if (size == 0)
                {
                    head = node;
                }
                else
                {
                    tail.next = node;
                    node.previous = tail;
                }

                tail = node;
                size++;
            }

            //Agregar al en frente
            public void AddAtFront(string data)
            {
                Node node = new Node (data);

                if (size == 0)
                {
                    tail = node;
                }
                else
                {
                    head.previous = node;
                }
                node.next = head;
                head = node;

                size++;
            }

            public void Remove(int index)
            {
                Node node = FindNode(index);

                //no tiene nada
                if (node == null)
                {
                    return;
                }

                if (size == 1)
                {
                    head = null;
                    tail = null;
                }
                else if (node == head)
                {
                    head = node.next;
                    if (head != null)
                    {
                        head.previous = null;
                    }
                }
                else if (node == tail)
                {
                    tail = node.previous;
                    if (tail != null)
                    {
                        tail.next = null;
                    }
                }
                else
                {//esta en medio
                    node.previous.next = node.next;
                    node.next.previous = node.previous;
                }
                size--;
            }

            //aqui utilizamos garbage colector
            public void RemoveAll()
            {
                head = null;
                tail = null;
                size = 0;
            }

            public void SetAt(int index, String data)
            {
                Node node = FindNode(index);

                if (node != null)
                {
                    node.data = data;
                }
            }

            /**
             * @param index 0-index
             * @return element at position index
             */
            //ve a una direccion,  cuendo lo encuentra, se regresa, si no es igual a data
            public string GetAt(int index)
            {
                Node node = FindNode(index);

                return node == null ? null : node.data;
            }

            //LinkedList me crea el Iterator
            public LinkedListIterator GetIterator()
            {
                return new LinkedListIterator (head);// El head es porq va a empezar ahi
            }

            public int GetSize()
            {
                return size;
            }

            private Node FindNode(int index)
            {

                if (index < 0 || index >= size)
                {
                    return null;
                }

                Node node = head;
                int currentIndex = 0;

                while (currentIndex != index)
                {
                    currentIndex++;
                    node = node.next;
                }

                return node;
            }
       
    }
}
