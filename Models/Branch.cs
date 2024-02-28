//Branch.cs
using System;

namespace LibraryManagement.Models
{
    public class Branch
    {
        public int BranchId {get;set;}
        public string BranchName {get;set;}
        public string Location {get;set;}

        public List<Book>? BookList {get;set;}

    }
}