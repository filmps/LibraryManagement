//Book.cs
using System;

namespace LibraryManagement.Models
{
    public class Book
    {
        public int BookId {get;set;}
        public string BookName {get;set;}

        public List<Author> AuthorList { get; set; } = new List<Author>();


    }
}