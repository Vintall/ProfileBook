using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ProfileBook.Models
{
    [Table("Accounts")]
    class Account
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        [Column("_login")]
        public string login { get; set; }
        [Column("_password")]
        public string password { get;set; }
        
    }
}
