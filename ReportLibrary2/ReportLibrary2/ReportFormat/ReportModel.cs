﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReportFormat.Model
{
    
    public class ReportModel
    {
        public ReportModel(string json)
        {
            JObject jObject = JObject.Parse(json);
            JToken jUser = jObject["myRoot"];
            ReportName = (string)jUser["ReportName"];
            ConnectionString = (string)jUser["ConnectionString"];
            SelectCommand = (string)jUser["SelectCommand"];
            GroupBy = jUser["GroupBy"].ToArray();
            GenerateTitleField = jUser["GenerateTitleField"].ToArray();
            GenerateDataField = jUser["GenerateDataField"].ToArray();
            Filters = jUser["Filters"].ToArray();
            SumOrCount = jUser["SumOrCount"].ToArray();
              }



        public string ReportName { get; set; }
        public string AddReportHeader { get; set; }

        //call only
        public string GenerateHeaderFooters { get; set; }

        //recieve connection string, no annotations
        public string ConnectionString { get; set; }

        //recieve selection string
        public string SelectCommand { get; set; }

        //recieve county
        public string CountyName { get; set; }

        //recieve data field, annotations define function
        public Array GroupBy { get; set; }

        public Array AddSortings { get; set; }

        public Array GenerateTitleField { get; set; }

        public Array GenerateDataField { get; set; }

        public Array SumOrCount { get; set; }

        public Array ChangeBandColor { get; set; }

        public Array Filters { get; set; }

        public string AddReportFooterSection { get; set; }
        public string AddPageNumbers { get; set; }

    }
}





