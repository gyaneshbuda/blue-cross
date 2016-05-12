using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortUsingGenerics
{
    public class Person : IComparable
    {

        #region Private Members

        private string _firstname;
        private string _lastname;

        #endregion

        #region Properties

        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        #endregion

        #region Contructors

        public Person(string firstname, string lastname)
        {
            _firstname = firstname;
            _lastname = lastname;
        }

        #endregion

        #region ToString()

        public override string ToString()
        {

            return String.Format("{0} {1}", _firstname, _lastname);

        }

        #endregion

        #region IComparable Members

        public int CompareTo(object obj)
        {

            if (obj is Person)
            {

                Person p2 = (Person)obj;
                if (_firstname == p2._firstname)
                    return _lastname.CompareTo(p2._lastname);
                return _firstname.CompareTo(p2._firstname);

            }
            else {
                throw new ArgumentException("Object is not a person.");
            }

        }

        #endregion

    }

    static public class BubbleSort
    {
        // Main Class
        public static void Main()
        {

            Person[] people = {
            new Person("Riya","Rose"),
            new Person("Priya", "Sharma"),
            new Person("Frank", "Smith"),
            new Person("Kim", "Knight"),
            new Person("Josh", "Martin"),
            new Person("Neesha", "Black"),
            new Person("Neesha", "Roy"),
            new Person("Neesha", "Ann"),};
            BubbleSortData(people);
            BubbleSort.DisplayPeople(people);

            //Output:
            /*
                Frank Smith
                Josh Martin
                Kim Knight
                Neesha Ann
                Neesha Black
                Neesha Roy
                Priya Sharma
                Riysa Rose
            */

        }

        //Sort the data using generics and bubble sort algorithms
        public static void BubbleSortData<T>(T[] arr) where T : IComparable
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        T Swap = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = Swap;
                    }
                }
            }
        }

        //Display the sorted data
        public static void DisplayPeople(Person[] people)
        {

            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }

        }

    }
}
