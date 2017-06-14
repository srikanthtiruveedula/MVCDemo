using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace MVCDemo.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name{get;set;}
        public string City { get;  set; }
        
   }
}