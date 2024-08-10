using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_FinalProject.Data
{
    internal class Book
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public long Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }

        //public Dictionary<int, string> GenreKey;

        //public Book()
        //{
        //    GenreKey = new Dictionary<int, string>
        //    {
        //        { 1, "Fiction" },
        //        { 2, "Non-Fiction" },
        //        { 3, "Science Fiction" },
        //        { 4, "Fantasy" },
        //        { 5, "Mystery" },
        //        { 6, "Horror" },
        //        { 7, "Romance" },
        //        { 8, "Biography" },
        //        { 9, "Autobiography" },
        //        { 10, "Self-Help" },
        //        { 11, "Cookbook" },
        //        { 12, "History" },
        //        { 13, "Poetry" },
        //        { 14, "Drama" },
        //        { 15, "Comics" },
        //        { 16, "Art" },
        //        { 17, "Science" },
        //        { 18, "Math" },
        //        { 19, "Philosophy" },
        //        { 20, "Religion" },
        //        { 21, "Travel" },
        //        { 22, "Children" },
        //        { 23, "Young Adult" },
        //        { 24, "Other" }
        //    };
        //}
    }
}
