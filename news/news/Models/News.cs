using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace news.Models
{
    public class News
    {
        public int id { get; set; }
        public string title { get; set; }
        public DateTime date { get; set; }
        public string image { get; set; }
        public string topic { get; set; }

        public int categorId { get; set; }
        public category category { get; set; }
    }
}
