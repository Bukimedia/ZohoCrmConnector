using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZohoCrmConnector.Entities
{
    class PurchaseOrders
    {
        public string PURCHASEORDERID { get; set; }
        public string SMOWNERID { get; set; }
        public string SMCREATORID { get; set; }
        public string MODIFIEDBY { get; set; }
        public string Created_Time { get; set; }
        public string Modified_Time { get; set; }

        public string Purchase_Order_Owner { get; set; }
        public string PO_Number { get; set; }
        public string Subject { get; set; }
        public string VENDORID { get; set; }
        public string Vendor_Name { get; set; }
        public string Requisition_No { get; set; }
        public string Tracking_Number { get; set; }
        public string CONTACTID { get; set; }
        public string Contact_Name { get; set; }
        public string PO_Date { get; set; }
        public string Due_Date { get; set; }
        public string Carrier { get; set; }
        public string Excise_Duty { get; set; }
        public string Sales_Commission { get; set; }
        public string Status { get; set; }
        public string Created_By { get; set; }
        public string Modified_By { get; set; }
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

        public string Sub_Total { get; set; }
        public string Tax { get; set; }
        public string Adjustment { get; set; }
        public string Grand_Total { get; set; }
        public string Product_Details { get; set; }

        /* Don't made it yet
         * 
         * public List<Products> List_Products { get; set; }
         * 
         * <FL val="Product Details">
         *     <product no="1">
         *         <FL val="Product Id">1122040000000090054</FL>
         *         <FL val="Product Name">
         *             <![CDATA[ Acer Ferrari 3200 Notebook Computer PC ]]>
         *         </FL>
         *         <FL val="Unit Price">2000.0</FL>
         *         <FL val="Quantity">2.0</FL>
         *         <FL val="Quantity in Stock">10.0</FL>
         *         <FL val="Total">3500.0</FL>
         *         <FL val="Discount">175.0</FL>
         *         <FL val="Total After Discount">3325.0</FL>
         *         <FL val="List Price">1750.0</FL>
         *         <FL val="Net Total">4023.25</FL>
         *         <FL val="Tax">698.25</FL>
         *         <FL val="Product Description">
         *             <![CDATA[ sdgdfgsdfg ]]>
         *         </FL>
         *     </product>
         *     <product no="2">...</product>
         * </FL>
         * 
         * */

        public string Terms_and_Conditions { get; set; }
        public string Description { get; set; }
        public string Discount { get; set; }
    }
}
