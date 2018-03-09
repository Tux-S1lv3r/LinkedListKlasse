using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListKlasse
{
    public class LinkedList
    {
        private class ListItem 
        {
        public object Item { get; }
        public ListItem Next { get; set; }

        public ListItem(object o)
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

        public object First
        {
            get
            {
                object resultat = null;
                if (itemCount>0)
                {
                    resultat = firstItem.Item;
                }
                return resultat;
            }
        }
        public object Last
        {
            get
            {
                object resultat = null;
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

        public object Items(int index)
        {
            object resultat = null;
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
        public void InsertFirst(object o)
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
        public void InsertLast(object o)
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
        public void Sort()
        {
            if (Count > 1)
            {
                for (int i = 0; i < Count; i++)
                {
                    ListItem item1 = firstItem;
                    ListItem item2 = firstItem.Next;

                    for (int j = 0; j < Count - 1 -1; j++)
                    {
                        Person person1;
                        Person person2;
                        person1 = (Person)item1.Item;
                        person2 = (Person)item2.Item;
                        bool firstItemSwapped = false;
                        //Denne blok skal kun køres, hvis Item1 og Item2 skal bytte plads.
                        if (person1.CompareTo(person2) > 0)
                        {
                            if (j !=0)
                            {
                                ListItem beforeItem1 = firstItem;

                                while (beforeItem1.Next.Equals(item1) == false)
                                {
                                    beforeItem1 = beforeItem1.Next;
                                }
                                beforeItem1.Next = item2;
                            }
                            else
                            {
                                firstItemSwapped = true;
                            }
                            item1.Next = item2.Next;
                            item2.Next = item1;

                            ListItem tmp;
                            tmp = item1;
                            item1 = item2;
                            item2 = tmp;

                            if (firstItemSwapped)
                            {
                                firstItem = item1;
                            }
                        }
                        //Item1 og Item2 rykker et trin fremad på listen, såfremt Item2 ikke er det sidste objekt.
                        if (item2.Next !=null)
                        {
                            item1 = item1.Next;
                            item2 = item2.Next;
                        }
                    }
                    lastItem = item2;
                }
            }


        }
    }
}
