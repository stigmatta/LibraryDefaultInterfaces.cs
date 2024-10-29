using BookClass;
using LibraryClass;

Book book1 = new Book("1984", "George Orwell", "Dystopian novel.", 1949, "Secker & Warburg");
Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", "Novel about racial injustice.", 1960, "J.B. Lippincott & Co.");
Book book3 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "Tragic story of Jay Gatsby.", 1925, "Charles Scribner's Sons");

Book book4 = (Book)book2.Clone();

Library library = new Library(new[]{book1,book2,book3,book4});

library.Show();

library.LibSort();
library.Show();

library.LibSortYear();
library.Show();

library.LibSortPublisher();
library.Show();



