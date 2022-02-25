using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample1.linkedlist
{
    internal class LinkedListIterator
    {
        private Node currentNode;

        internal LinkedListIterator (Node startNode)
        {
            currentNode = startNode;
        }

        //le digo que siga cuando no sea null
        public Boolean HasNext()
        {
            return currentNode != null;
        }

        public string Next()
        {
            string data = currentNode.data; //obtener el dato q q apunta y current data se guarda

            currentNode = currentNode.next;//avanzo

            return data;
        }
    }
}
