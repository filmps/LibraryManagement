//Author.cs
using System;
using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Author
    {
        //AUTHOR ATTRIBUTE---------------------------------
        public int AuthorId {get;set;}

        [Required(ErrorMessage = "Author name is required")]
        public string AuthorName {get;set;}


        //AUTHOR ATTRIBUTE---------------------------------
        public List<Book>? BookList {get;set;}
        
        public int? SelectedBookId { get; set; }
    }
}