using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListKlasse
{
    public enum Gender { Male, Female }

    public class Person : IComparable
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public override string ToString()
        {
            return $"{Id}: {FullName} ({Gender}), {Age} years";
        }
        public int CompareTo(object obj)
        {
            Person otherPerson = (Person)obj;
            return this.FullName.CompareTo(otherPerson.FullName);
        }
        //    public static IComparer<Person> SortAgeAscending();
        //    {
        //        return (IComparer<Person>)new sortAgeAscendingHelper();
        //    }
        //private class sortAgeAscendingHelper : IComparer<Person>
        //{
        //    public int Compare(Person x, Person y)
        //    {
        //        if (x.Age > y.Age)
        //        {
        //            return 1;
        //        }
        //        else if (x.Age < y.Age)
        //        {
        //            return -1;
        //        }
        //        else
        //        {
        //            return 0;
        //        }
        //    }
        //}
    }
}
