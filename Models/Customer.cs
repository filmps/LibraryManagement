//Customer.cs
using System;

namespace LibraryManagement.Models
{
    public class Customer
    {
        public int CustomerId {get;set;}
        public string CustomerName {get;set;}

        public List<Book> BookList { get; set; } = new List<Book>();

    }
}