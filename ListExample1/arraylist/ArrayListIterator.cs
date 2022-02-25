using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExample1.arraylist
{
    internal class ArrayListIterator
    {
        private ArrayList arrayList;
        private int currentItem;

        internal ArrayListIterator(ArrayList arrayList)
        {
            this.arrayList = arrayList;
        }

        public bool HasNext()
        {
            return currentItem < arrayList.GetSize();
        }

        public string Next()
        {
            string data = arrayList.GetAt(currentItem);

            currentItem++;
            return data;
        }
    }
}
