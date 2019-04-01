using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7Database
{
    public class PersonModel
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }
        public int LuckyNumber { get; set; }
    }
}
