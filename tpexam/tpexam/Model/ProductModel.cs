using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace tpexam.Model
{
    public class ProductModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public float Prix { get; set; }
        public string category { get; set; }

    }
}
