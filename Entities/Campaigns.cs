using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZohoCrmConnector.Entities
{
    class Campaigns
    {
        public string CAMPAIGNID { get; set; }
        public string SMOWNERID { get; set; }
        public string SMCREATORID { get; set; }
        public string MODIFIEDBY { get; set; }
        public string Created_Time { get; set; }
        public string Modified_Time { get; set; }

        public string Campaign_Owner { get; set; }
        public string Type { get; set; }
        public string Campaign_Name { get; set; }
        public string Status { get; set; }
        public string Start_Date { get; set; }
        public string End_Date { get; set; }
        public string Expected_Revenue { get; set; }
        public string Budgeted_Cost { get; set; }
        public string Actual_Cost { get; set; }
        public string Expected_Response { get; set; }
        public string Num_sent { get; set; }
        public string Created_By { get; set; }
        public string Modified_By { get; set; }
        public string Description { get; set; }
    }
}
