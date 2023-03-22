using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Example
{
    public class Blog
    {
        public Guid id { get; set; }
        public string? text { get; set; }
        public string? Title { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
    }
}