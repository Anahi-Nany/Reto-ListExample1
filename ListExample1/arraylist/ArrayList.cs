using ListExample1.arraylist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample1
{
    internal class ArrayList
    {
            //private static final int DEFAULT_SIZE = 50;
            private string[] array;
        private int size;

            internal ArrayList()
            {
                array = new string[50];
            }

            internal ArrayList(int size)
            {
                array = new String[size];
            }

            public void AddAtTail(string data)
            {
                if (size == array.Length)
                {
                    IncreaseArraySize();
                }
                array[size] = data;
                size++;
            }

            //Agregar al frente
            public void AddAtFront(string data)
            {
                if (size == array.Length)
                {
                    IncreaseArraySize();
                }

                if (size >= 0)
                {
                Array.Copy(array, 0, array, 1, size);
            }
                array[0] = data;
                size++;
            }

            //se recorren datos y se disminuye size
            public void Remove(int index)
            {
                if (index < 0 || index >= size)
                {
                    return;
                }

                for (int i = index; i < size - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                array[size - 1] = null; // para q garbage colector detecte los objetos mas rapido
                size--;
            }

            public void RemoveAll()
            {
                for (int i = 0; i < size - 1; i++)
                {
                    array[i] = null;
                }
                size = 0;
            }

            public void SetAt(int index, string data)
            {
                if (index >= 0 && index < size)
                {
                    array[index] = data;
                }
            }


            //ve a una direccion,  cuendo lo encuentra, se regresa, si no es igual a data
            public string GetAt(int index)
            {
                return index >= 0 && index < size ? array[index] : null;
            }

            public ArrayListIterator GetIterator(){
                return new ArrayListIterator( this );
            }

            public int GetSize()
            {
                return size;
            }

            private void IncreaseArraySize()
            {
                string[] newArray = new string[array.Length * 2];

                for (int i = 0; i < size; i++)
                {
                    newArray[i] = array[i];
                }
                array = newArray;
            }
    }
}
