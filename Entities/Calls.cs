using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZohoCrmConnector.Entities
{
    class Calls
    {
        public string ACTIVITYID { get; set; }
        public string SMOWNERID { get; set; }
        public string SMCREATORID { get; set; }
        public string MODIFIEDBY { get; set; }
        public string Created_Time { get; set; }
        public string Modified_Time { get; set; }

        public string Call_Owner { get; set; }
        public string Subject { get; set; }
        public string Call_Type { get; set; }
        public string Call_Purpose { get; set; }
        public string RELATEDTOID { get; set; }
        public string SEMODULE { get; set; }
        public string Related_To { get; set; }
        public string Call_Start_Time { get; set; }
        public string Call_Duration { get; set; }
        public string Call_Duration_in_seconds { get; set; }
        public string Description { get; set; }
        public string Billable { get; set; }
        public string Call_Result { get; set; }
        public string Created_By { get; set; }
        public string Modified_By { get; set; }
    }
}
