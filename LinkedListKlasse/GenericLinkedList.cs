using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListKlasse
{

    public class LinkedList<T>
    {
        private class ListItem
        {
            public T Item { get; }
            public ListItem Next { get; set; }

            public ListItem(T o)
            {
                Item = o;
            }
            public override string ToString()
            {
                return Item.ToString();
            }
        }
        private ListItem firstItem = null;
        private ListItem lastItem = null;
        private int itemCount = 0;

        public T First
        {
            get
            {
                T resultat = default(T);
                if (itemCount > 0)
                {
                    resultat = firstItem.Item;
                }
                return resultat;
            }
        }
        public T Last
        {
            get
            {
                T resultat = default(T);
                if (itemCount > 0)
                {
                    resultat = lastItem.Item;
                }
                return resultat;
            }
        }
        public int Count
        {
            get
            {
                return itemCount;
            }
        }

        public T Items(int index)
        {
            T resultat = default(T);
            if (index < itemCount && index >= 0)
            {
                ListItem tempItem = firstItem;
                for (int i = 0; i < index; i++)
                {
                    tempItem = tempItem.Next;
                }
                resultat = tempItem.Item;
            }
            else
            {
                //throw exception out of range
            }
            return resultat;
        }
        public void InsertFirst(T o)
        {
            ListItem n = new ListItem(o);
            if (itemCount == 0)
            {
                firstItem = n;
                lastItem = n;
            }
            else
            {
                n.Next = firstItem;
                firstItem = n;
            }
            itemCount++;
        }
        public void InsertLast(T o)
        {
            ListItem n = new ListItem(o);
            if (itemCount == 0)
            {
                firstItem = n;
                lastItem = n;
            }
            else
            {
                lastItem.Next = n;
                lastItem = n;
            }
            itemCount++;
        }
        public void RemoveAt(int index)
        {
            if (index < itemCount && index >= 0)
            {
                if (index == 0)
                {
                    firstItem = firstItem.Next;
                }
                else
                {
                    ListItem tempItem = firstItem;
                    for (int i = 0; i < index - 1; i++)
                    {
                        tempItem = tempItem.Next;
                    }
                    tempItem.Next = tempItem.Next.Next;
                    if (index == itemCount - 1)
                    {
                        lastItem = tempItem;
                    }
                }

                itemCount--;
            }
            else
            {
                //throw exception out of range
            }
        }
        public override string ToString()
        {
            string resultat = "";
            ListItem tempItem = firstItem;
            while (tempItem != null)
            {
                resultat = resultat + tempItem.ToString();
                if (tempItem.Next != null)
                {
                    resultat = resultat + "|";
                }
                tempItem = tempItem.Next;
            }
            return resultat;
        }
    }

}
