using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class QueryBuilderRule
    {
        public string condition { get; set; }
        public string id { get; set; }
        public string field { get; set; }
        public string type { get; set; }
        public string input { get; set; }
        public string @operator { get; set; }
        public string[] value { get; set; }
        public List<QueryBuilderRule> rules { get; set; }
        public Dictionary<string, string> flags { get; set; }
        public bool @readonly { get; set; }
        public bool hidden { get; set; }
    } 
}
