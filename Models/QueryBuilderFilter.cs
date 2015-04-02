using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class QueryBuilderFilter
    {
        public string id { get; set; }
        //public string field { get; set; }
        public string label { get; set; }
        public string type { get; set; }
        public string input { get; set; }
        public Dictionary<string, string> values { get; set; }
        public string default_value { get; set; }
        //public int size { get; set; }
        //public int rows { get; set; }
        public bool multiple { get; set; }
        public string placeholder { get; set; }
        //public bool vertical { get; set; }
        public string optgroup { get; set; }
        public Dictionary<string, string> validation { get; set; }
        public string[] operators { get; set; }

        //public string plugin { get; set; }
        //public Dictionary<string, string> plugin_config { get; set; }
    }
}
