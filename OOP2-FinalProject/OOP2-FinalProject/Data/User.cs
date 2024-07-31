using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_FinalProject.Data
{
    internal class User
    {
        [PrimaryKey, AutoIncrement]
        public int IdNum { get; set; }
        public string LibNum { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
    }
}
