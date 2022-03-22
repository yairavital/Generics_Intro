using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson20HW
{
    internal class Book
    {
    

        public string Title { get; private set; }
        public string Content { get; private set; }
        public string Author { get; private set; }
        public string Category { get; private set; }
        public Book(string title, string content, string author, string category)
        {
            Title = title;
            Content = content;
            Author = author;
            Category = category;
        }
        public override string ToString()
        {
            return $"The title is {Title} and the content is: {Content}, the Author is: {Author} and the category is: {Category}";
        }

    }
}
