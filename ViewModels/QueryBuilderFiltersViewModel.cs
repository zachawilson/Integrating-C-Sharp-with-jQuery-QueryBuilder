using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using Models;

namespace ViewModels
{

    public class QueryBuilderFiltersViewModel
    {
        public List<QueryBuilderFilterViewModel> Filter { get; set; }

        public List<QueryBuilderFilter> Definitions { get; set; }

        #region Private Properties

        public enum DateOption
        {
            Today,
            Yesterday,
            WeekToDate,
            LastWeek,
            MonthToDate,
            Last30Days,
            LastMonth,
            YearToDate,
            CustomDateRange
        }

        // TODO: Localize data
        public static Dictionary<string, string> DateOptionsLocalized = new Dictionary<string, string>
        {
            {DateOption.CustomDateRange.ToString(), DateOption.CustomDateRange.ToString()},
            {DateOption.Today.ToString(), DateOption.Today.ToString()},
            {DateOption.Yesterday.ToString(), DateOption.Yesterday.ToString()},
            {DateOption.WeekToDate.ToString(), DateOption.WeekToDate.ToString()},
            {DateOption.LastWeek.ToString(), DateOption.LastWeek.ToString()},
            {DateOption.MonthToDate.ToString(), DateOption.MonthToDate.ToString()},
            {DateOption.Last30Days.ToString(), DateOption.Last30Days.ToString()},
            {DateOption.LastMonth.ToString(), DateOption.LastMonth.ToString()},
            {DateOption.YearToDate.ToString(), DateOption.YearToDate.ToString()}
        };
            {CallHandlerOption.StringNumberSearch.ToString(), CallHandlerOption.StringNumberSearch.ToString()},
            {CallHandlerOption.DelimitedNumbers.ToString(), CallHandlerOption.DelimitedNumbers.ToString()}
        };

        #endregion

        public QueryBuilderFiltersViewModel()
        {
        }

        public QueryBuilderFiltersViewModel(bool getall)
        {
            Get(getall);
        }

        public void Get(bool getall)
        {
            if (System.Web.HttpContext.Current == null) return;

            this.Filter = new QueryBuilderFilterViewModel(getall);
            this.Definitions = GetFilterDefinitions();
        }

        public void Initialize()
        {

        }

        public static List<QueryBuilderFilter> GetFilterDefinitions()
        {
            return new List<QueryBuilderFilter>
            {
               
                new QueryBuilderFilter
                {
                    id = "LowDuration",
                    label = "Min Duration",
                    type = "string",
                    optgroup = "Time Frame",
                    placeholder = "00:00:00",
                    validation = new Dictionary<string, string>{{"format", "^[0-9]{2}:[0-5]{1}[0-9]{1}:[0-5]{1}[0-9]{1}$"}},
                    operators = new string[1] {"equal"} 
                },
                new QueryBuilderFilter
                {
                    id = "HighDuration",
                    label = "Max Duration",
                    type = "string",
                    optgroup = "Time Frame",
                    placeholder = "00:00:00",
                    validation = new Dictionary<string, string>{{"format", "^[0-9]{2}:[0-5]{1}[0-9]{1}:[0-5]{1}[0-9]{1}$"}},
                    operators = new string[1] {"equal"} 
                },
                new QueryBuilderFilter
                {
                    id = "DateRangeSelectorValue",
                    label = "Time Frame",
                    type = "string",
                    input = "select",
                    optgroup = "Time Frame",
                    values = DateOptionsLocalized,
                    operators = new string[1] {"equal"}
                },
                new QueryBuilderFilter
                {
                    id = "FromDate",
                    label = "Start Date",
                    type = "string",
                    placeholder = "0001-01-01",
                    optgroup = "Time Frame",
                    operators = new string[1] {"equal"},
                },
                new QueryBuilderFilter
                {
                    id = "ToDate",
                    label = "End Date",
                    type = "string",
                    placeholder = "0001-01-01",
                    optgroup = "Time Frame",
                    operators = new string[1] {"equal"}
                },
                new QueryBuilderFilter
                {
                    id = "FromTime",
                    label = "Start Time",
                    type = "string",
                    placeholder = "00:00",
                    optgroup = "Time Frame",
                    operators = new string[1] {"equal"},
                },
                new QueryBuilderFilter
                {
                    id = "ToTime",
                    label = "End Time",
                    type = "string",
                    placeholder = "00:00",
                    optgroup = "Time Frame",
                    operators = new string[1] {"equal"}
                },
                new QueryBuilderFilter
                {
                    id = "RandomPercent",
                    label = "Random Percentage of Calls",
                    type = "integer",
                    input = "text",
                    optgroup = "Other",
                    validation = new Dictionary<string, string>{{"min", "1"}, {"max", "100"}},
                    //validation = new Dictionary<string, string>{{"format", "^100$|^[123456789][0-9]$|^[0-9]$"}},
                    operators = new string[1] {"equal"}
                },
                new QueryBuilderFilter
                {
                    id = "ShowDeletedCalls",
                    label = "Deleted Calls",
                    type = "string",
                    input = "checkbox",
                    optgroup = "Other",
                    values = new Dictionary<string, string> {{"1", "Show deleted calls"}},
                    operators = new string[1] {"equal"}
                }
                
            };
        }
    }
}

