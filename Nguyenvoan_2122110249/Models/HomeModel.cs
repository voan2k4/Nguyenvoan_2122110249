using Nguyenvoan_2122110249.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nguyenvoan_2122110249.Models
{
    public class HomeModel
    {
        public  List<Product> ListProduct { get; set; }
        public List<Category> ListCategory { get; set; }

    }
}