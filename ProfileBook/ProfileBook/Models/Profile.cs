using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ProfileBook.Models
{
    [Table("Profiles")]
    class Profile
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int id { get; set; }
        [Column("_first_name")]
        public string first_name { get; set; }
        [Column("_last_name")]
        public string last_name { get; set; }
        [Column("_owner_id")]
        public int owner_id { get; set; }
    }
}
