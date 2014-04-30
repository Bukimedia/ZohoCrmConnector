using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZohoCrmConnector.Entities
{
    class Contacts
    {
        public string CONTACTID { get; set; }
        public string SMOWNERID { get; set; }
        public string SMCREATORID { get; set; }
        public string MODIFIEDBY { get; set; }
        public string Created_Time { get; set; }
        public string Modified_Time { get; set; }

        public string ACCOUNTID { get; set; }

        public string Contact_Owner { get; set; }
        public string Lead_Source { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Account_Name { get; set; }
        public string Vendor_Name { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public string Phone { get; set; }
        public string Home_Phone { get; set; }
        public string Other_Phone { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Date_of_Birth { get; set; }
        public string Assistant { get; set; }
        public string Asst_Phone { get; set; }
        public string Reports_To { get; set; }
        public string Email_Opt_Out { get; set; }
        public string Created_By { get; set; }
        public string Skype_ID { get; set; }
        public string Modified_By { get; set; }
        public string Add_to_QuickBooks { get; set; }
        public string Salutation { get; set; }
        public string Secondary_Email { get; set; }
        public string Last_Activity_Time { get; set; }
        public string Twitter { get; set; }
        public string Mailing_Street { get; set; }
        public string Other_Street { get; set; }
        public string Mailing_City { get; set; }
        public string Other_City { get; set; }
        public string Mailing_State { get; set; }
        public string Other_State { get; set; }
        public string Mailing_Zip { get; set; }
        public string Other_Zip { get; set; }
        public string Mailing_Country { get; set; }
        public string Other_Country { get; set; }
        public string Description { get; set; }
    }
}
