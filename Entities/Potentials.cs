using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZohoCrmConnector.Entities
{
    class Potentials
    {
        public string POTENTIALID { get; set; }
        public string SMOWNERID { get; set; }
        public string SMCREATORID { get; set; }
        public string MODIFIEDBY { get; set; }
        public string Created_Time { get; set; }
        public string Modified_Time { get; set; }

        public string Potential_Owner { get; set; }
        public string Amount { get; set; }
        public string Potential_Name { get; set; }
        public string Closing_Date { get; set; }
        public string ACCOUNTID { get; set; }
        public string Account_Name { get; set; }
        public string Stage { get; set; }
        public string Type { get; set; }
        public string Probability { get; set; }
        public string Next_Step { get; set; }
        public string Expected_Revenue { get; set; }
        public string Lead_Source { get; set; }
        public string Campaign_Source { get; set; }
        public string Contact_Name { get; set; }
        public string Created_By { get; set; }
        public string Modified_By { get; set; }
        public string Last_Activity_Time { get; set; }
        public string Description { get; set; }

        public string Sales_Cycle_Duration { get; set; }
        public string Overall_Sales_Duration { get; set; }
    }
}
