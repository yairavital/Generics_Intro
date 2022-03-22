using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson20HW
{
    internal class MyLibrary
    {
        Dictionary<string,Book> books = new Dictionary<string,Book>();

        public MyLibrary()
        {
        }

        public MyLibrary(Dictionary<string, Book> booksDict)
        {
            this.books = booksDict;
        }
        public bool AddBook(Book book)
        { bool isExist = true;
            foreach (Book book1 in books.Values)
            {
                if (book1 == book)
                    isExist = false;
            }
            books.Add(book.Title, book);
            return isExist;

        }
        public bool RemoveBook(string keyBook)
        {
            if(books.Remove(keyBook))
                return true;
            return false;
        }
        public bool HaveThisBook(string keyBook)
        {
            return books.ContainsKey(keyBook);
        }
        public Book? GetBook(string title)
        {
    
            foreach (Book book in books.Values)
            {if(book.Title== title)
                    return book;

            }
            return null;
        }
        public Book? GetBookByAuthor(string author)
        {
            foreach ( Book book in books.Values)
            {
                if(book.Author == author)
                    return book;
            }
            return null;
        }
        public void Clear()
        {
            books.Clear();
        }
        public List<string> GetAuthors()
        {
            List<string> authors = new List<string>();
            foreach ( Book book in books.Values )
            {
                authors.Add(book.Author);
            }   
            return authors;
        }
        public List<Book> GetBooksSortedByAuthorName()
        {
            List<Book> authorsSort = books.Values.OrderBy(book => book.Author).ToList();

            return authorsSort;

        }
        public List<string> GetBooksTitleSorted()
        {
            List<string> titleSort = new List<string>();
          titleSort= books.Keys.OrderBy(x => x).ToList();


            return titleSort;

        }
        public override string ToString()
        { string print = "";
            foreach( KeyValuePair<string,Book> keyValuePair in books )
            {
                
               print+= keyValuePair.Key+": "+keyValuePair.Value.ToString()+"\n";
            }
            return print;
        }
        public int Count()
        {
            int count = 0;
            foreach (Book book in books.Values)
            {
                count++;
            }
            return count;
        }
    }
}
