
using BookClass;
using System.Collections;

namespace LibraryClass
{
    public class Library : IEnumerable, IEnumerator
    {
        private Book[] arr;
        int curpos = -1;

        public Library(Book[] arr)
        {
            this.arr = arr;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public void Reset()
        {
            curpos = -1;
        }
        public object Current 
        {
            get
            {
                return arr[curpos];
            }
        }

        public bool MoveNext()
        {
            if (curpos < arr.Length - 1)
            {
                curpos++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }

        }

        public void Show() {
            foreach(Book book in arr)
            {
                book.Show();
            }
            Console.WriteLine("SHOW ENDED\n");
        }

        public void LibSort()
        {
            Console.WriteLine("Regular sorting library(by title)\n");
            Array.Sort(arr);
        }

        public void LibSortYear()
        {
            Console.WriteLine("Sorting library by year\n");
            Array.Sort(arr,new Book.SortByYear());
        }
        public void LibSortAuthor() {

            Console.WriteLine("Sorting library by author\n");
            Array.Sort(arr, new Book.SortByAuthor());
        }
        public void LibSortPublisher()
        {
            Console.WriteLine("Sorting library by publisher\n");
            Array.Sort(arr, new Book.SortByPublisher());
        }

    }
}
