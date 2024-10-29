using System.Collections;

namespace BookClass
{
    public class Book : ICloneable, IComparable
    {
        private string title;
        private string author;
        private string description;
        private int year;
        private string publisher;

        public string Title
        {
            get { return title; } set
            {
                if (string.IsNullOrEmpty(value))
                    return;
                title = value;
            }
        }

        public string Author
        {
            get { return author; }
            set
            {
                if (string.IsNullOrEmpty(value)) return;
                author = value;
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (string.IsNullOrEmpty(value)) return;
                description = value;
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value > DateTime.Now.Year)
                    return;

                year = value;

            }
        }

        public string Publisher
        {
            get { return publisher; }
            set
            {
                if (string.IsNullOrEmpty(value)) return;
                publisher = value;
            }
        }

        public Book(string title, string author, string description, int year, string publisher)
        {
            Title = title;
            Author = author;
            Description = description;
            Year = year;
            Publisher = publisher;
        }

        public void Show()
        {
            Console.WriteLine("Title - {0}\nYear - {1}\nAuthor - {2}\nPublisher - {3}\nDescription - {4}\n\n", Title, Year, Author, Publisher, Description);
        }

        public object Clone()
        {
            return new Book(Title,Author,Description,Year,Publisher);
        }

        public int CompareTo(object? obj)
        {
            if(obj is Book)
                return Title.CompareTo((obj as Book).Title);

            throw new NotImplementedException();

        }

        #region ComparingClasses
        public class SortByYear : IComparer
        {
            public int Compare(object? x, object? y)
            {
                if (x is Book && y is Book)
                    return (x as Book).Year.CompareTo((y as Book).Year);
                throw new NotImplementedException();
            }
        }

        public class SortByPublisher : IComparer
        {
            public int Compare(object? x, object? y)
            {
                if (x is Book && y is Book)
                    return (x as Book).Publisher.CompareTo((y as Book).Publisher);
                throw new NotImplementedException();
            }
        }

        public class SortByAuthor : IComparer
        {
            public int Compare(object? x, object? y)
            {
                if (x is Book && y is Book)
                    return (x as Book).Author.CompareTo((y as Book).Author);
                throw new NotImplementedException();
            }
        }
        #endregion
    }


}
