using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZohoCrmConnector.Entities
{
    public class Products
    {
        public string PRODUCTID { get; set; }
        public string SMOWNERID { get; set; }
        public string SMCREATORID { get; set; }
        public string MODIFIEDBY { get; set; }
        public string Created_Time { get; set; }
        public string Modified_Time { get; set; }

        public string Product_Owner { get; set; }
        public string Product_Name { get; set; }
        public string Product_Code { get; set; }
        public string VENDORID { get; set; }
        public string Vendor_Name { get; set; }
        public string Product_Active { get; set; }
        public string Manufacturer { get; set; }
        public string Product_Category { get; set; }
        public string Sales_Start_Date { get; set; }
        public string Sales_End_Date { get; set; }
        public string Support_Start_Date { get; set; }
        public string Support_Expiry_Date { get; set; }
        public string Created_By { get; set; }
        public string Modified_By { get; set; }
        public string Unit_Price { get; set; }
        public string Commission_Rate { get; set; }
        public string Tax { get; set; }
        public string Taxable { get; set; }
        public string Usage_Unit { get; set; }
        public string Qty_Ordered { get; set; }
        public string Qty_in_Stock { get; set; }
        public string Recorder_Level { get; set; }
        public string Handler { get; set; }
        public string Qty_in_Demand { get; set; }
        public string Description { get; set; }
    }
}
