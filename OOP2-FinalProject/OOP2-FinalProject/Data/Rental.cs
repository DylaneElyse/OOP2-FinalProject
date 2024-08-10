using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_FinalProject.Data
{
    internal class Rental
    {
        [PrimaryKey, AutoIncrement]
        public int RentNum { get; set; }
        public int LibNum { get; set; }
        public long Isbn { get; set; }
        public DateTime BorrowDate { get; set; } = DateTime.Now;
        public DateTime ReturnDate { get; set; }
    }
}
