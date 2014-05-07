using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZohoCrmConnector.Entities
{
    public class Leads
    {
        public string LEADID { get; set; }
        public string SMOWNERID { get; set; }
        public string Lead_Owner { get; set; }
        public string Company { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Website { get; set; }
        public string Lead_Source { get; set; }
        public string Lead_Status { get; set; }
        public string Industry { get; set; }
        public string No_of_Employees { get; set; }
        public string Annual_Revenue { get; set; }
        public string Rating { get; set; }
        public string SMCREATORID { get; set; }
        public string Created_By { get; set; }
        public string MODIFIEDBY { get; set; }
        public string Modified_By { get; set; }
        public string Created_Time { get; set; }
        public string Modified_Time { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip_Code { get; set; }
        public string Country { get; set; }
        public string Skype_ID { get; set; }
        public string Description { get; set; }
        public string Email_Opt_Out { get; set; }
        public string Salutation { get; set; }
        public string Secondary_Email { get; set; }
        public string Last_Activity_Time { get; set; }
        public string Twitter { get; set; }
    }
}
