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
        public string fName { get; set; }
        public string lName { get; set; }
        public string email { get; set; }
    }
}
