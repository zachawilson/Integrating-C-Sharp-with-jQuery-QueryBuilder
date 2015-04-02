using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Models;

namespace ViewModels
{

    public class QueryBuilderFilterViewModel
    {
        public QueryBuilderRule Rules { get; set; }

        public QueryBuilderFilterViewModel()
        {
        }
		
		public QueryBuilderFilterViewModel(bool getall)
        {
			if (getall)
			this.Rules = GetDefaultRules();
        }

        public static QueryBuilderRule GetRules()
        {
            return new QueryBuilderRule
            {
                condition = "AND",
                rules = new List<QueryBuilderRule>
                {
                    new QueryBuilderRule
                    {
                        id = "DateRangeSelectorValue",
                        field = "DateRangeSelectorValue",
                        type = "string", 
                        input = "select",
                        @operator = "equal",
                        hidden = false,
                        //@readonly = true,
                        flags = new Dictionary<string, string> {{"no_delete", "true"}, {"filter_readonly", "true"}, {"operator_readonly", "true"}}
                    },
                    new QueryBuilderRule
                    {
                        id = "FromDate",
                        field = "FromDate",
                        type = "string", 
                        input = "text",
                        @operator = "equal",
                        hidden = false//,
                        //@readonly = true,
                        //flags = new Dictionary<string, string> {{"no_delete", "true"}, {"filter_readonly", "true"}, {"operator_readonly", "true"}}
                    },
                    new QueryBuilderRule
                    {
                        id = "FromTime",
                        field = "FromTime",
                        type = "string", 
                        input = "text",
                        @operator = "equal",
                        hidden = false
                    },
                    new QueryBuilderRule
                    {
                        id = "HighDuration",
                        field = "HighDuration",
                        type = "string",
                        input = "text",
                        @operator = "equal",
                        hidden = false
                    },
                    new QueryBuilderRule
                    {
                        id = "LowDuration",
                        field = "LowDuration",
                        type = "string",
                        input = "text",
                        @operator = "equal",
                        hidden = false
                    },
                    new QueryBuilderRule
                    {
                        id = "ToDate",
                        field = "ToDate",
                        type = "string", 
                        input = "text",
                        @operator = "equal",
                        hidden = false//,
                        //@readonly = true,
                        //flags = new Dictionary<string, string> {{"no_delete", "true"}, {"filter_readonly", "true"}, {"operator_readonly", "true"}}
                    },
                    new QueryBuilderRule
                    {
                        id = "ToTime",
                        field = "ToTime",
                        type = "string", 
                        input = "text",
                        @operator = "equal",
                        hidden = false
                    }
                }
            }
        }
    }
}

