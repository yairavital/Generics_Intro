using Lesson20HW;
using System.Collections.Generic;
Book b1 = new Book("Friend", "Once upon a time", "jon alb", "Science Fiction");
Book b2 = new Book("Bad Day", "If you ever loved someone", "Noy Fic", "Romanticism");
Book b3 = new Book("The black day", "I scream I really dont know what to do", "Alen Jo", "Thriller");
Dictionary<string, Book> books = new Dictionary<string, Book>()
{ {b1.Title, b1 },
{ b2.Title, b2},
{ b3.Title, b3 }
};
MyLibrary myLib = new MyLibrary(books);
//Console.WriteLine(myLib.Count());
//List<string> authors =myLib.GetAuthors();
//foreach (var author in authors)
//{
//    Console.WriteLine(author);
//}
//myLib.Clear();
//Console.WriteLine(myLib.Count());
//Book bookByAuthor = myLib.GetBookByAuthor("jon alb");
//Console.WriteLine(bookByAuthor.Title);
//Book bookByTitle = myLib.GetBook("The black day");
//Console.WriteLine(bookByTitle.Author);
//Console.WriteLine(myLib.HaveThisBook("dkj"));
//Console.WriteLine(myLib.HaveThisBook("First"));
//Console.WriteLine(myLib.RemoveBook("First"));
//Console.WriteLine(myLib.RemoveBook("Fir"));
//Book b4 = new Book("The black day", "I scream I really dont know what to do", "Alen Jo", "Thriller");
//Console.WriteLine(myLib.AddBook(b3));
//Console.WriteLine(myLib.AddBook(b4));
//List<string> booksNameSort = myLib.GetBooksTitleSorted();
//foreach (string book in booksNameSort)
//{
//    Console.WriteLine(book.ToString());
//}
//List<Book> booksNameSort = myLib.GetBooksSortedByAuthorName();
//foreach (Book book in booksNameSort)
//{
//    Console.WriteLine(book.ToString());
//}
Console.WriteLine(myLib.ToString());