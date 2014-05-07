using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZohoCrmConnector.Entities
{
    public class Cases
    {
        public string CASEID { get; set; }
        public string SMOWNERID { get; set; }
        public string SMCREATORID { get; set; }
        public string MODIFIEDBY { get; set; }
        public string Created_Time { get; set; }
        public string Modified_Time { get; set; }

        public string Case_Owner { get; set; }
        public string Status { get; set; }
        public string Product_Name { get; set; }
        public string Priority { get; set; }
        public string Type { get; set; }
        public string Case_Reason { get; set; }
        public string Case_Origin { get; set; }
        public string Subject { get; set; }
        public string Related_To { get; set; }
        public string Account_Name { get; set; }
        public string Reported_By { get; set; }
        public string Potential_Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Created_By { get; set; }
        public string Modified_By { get; set; }
        public string Description { get; set; }
        public string Internal_Comments { get; set; }
        public string Solution { get; set; }

        public List<AuxEntities.AuxComments> Comments { get; set; }

        public string Case_Number { get; set; }
        public string PRODUCTID { get; set; }
        public string WHOID { get; set; }
        public string No_of_comments { get; set; }
        public string ACCOUNTID { get; set; }
        public string POTENTIALID { get; set; }
    }
}
