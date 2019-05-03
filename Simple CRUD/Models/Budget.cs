using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Simple_CRUD.Models
{
    public class Budget
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int month { get; set; }
        public int year { get; set; }
    }
}