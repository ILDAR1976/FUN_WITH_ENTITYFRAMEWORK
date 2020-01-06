using System;
using System.Linq;
using System.Text;
using Library.DataModel;
using MySql.Data.Entity;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace Library
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    class Program
    {
        static void Main(string[] args)
        {
            using (LibraryModel context = new LibraryModel())
            {
                Book book = new Book();
                book.Title = "Анна Каренина";
                book.Author = "Лев Толстой";

                context.Books.Add(book);
                context.SaveChanges();
            }
        }
    }
}
