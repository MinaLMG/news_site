using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace news.Models
{
    public class category
    {
        public int id { get; set; }
        public string name { get; set; }
        public string DISCRIPTION { get; set; }
        public List<News> news { get; set; }
    }
}
