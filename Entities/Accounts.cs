using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZohoCrmConnector.Entities
{
    public class Accounts
    {
        public string ACCOUNTID { get; set; }
        public string SMOWNERID { get; set; }
        public string SMCREATORID { get; set; }
        public string MODIFIEDBY { get; set; }
        public string Created_Time { get; set; }
        public string Modified_Time { get; set; }

        public string Account_Owner { get; set; }
        public string Rating { get; set; }
        public string Account_Name { get; set; }
        public string Phone { get; set; }
        public string Account_Site { get; set; }
        public string Fax { get; set; }
        public string Parent_Account { get; set; }
        public string Website { get; set; }
        public string Account_Number { get; set; }
        public string Ticker_Symbol { get; set; }
        public string Account_Type { get; set; }
        public string Ownership { get; set; }
        public string Industry { get; set; }
        public string Employees { get; set; }
        public string Annual_Revenue { get; set; }
        public string SIC_Code { get; set; }
        public string Created_By { get; set; }
        public string Modified_By { get; set; }
        public string Last_Activity_Time { get; set; }
        public string Billing_Street { get; set; }
        public string Shipping_Street { get; set; }
        public string Billing_City { get; set; }
        public string Shipping_City { get; set; }
        public string Billing_State { get; set; }
        public string Shipping_State { get; set; }
        public string Billing_Code { get; set; }
        public string Shipping_Code { get; set; }
        public string Billing_Country { get; set; }
        public string Shipping_Country { get; set; }
        public string Description { get; set; }
    }
}
