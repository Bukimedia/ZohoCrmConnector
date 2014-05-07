using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZohoCrmConnector.Entities
{
    public class PriceBooks
    {
        public string BOOKID { get; set; }
        public string SMOWNERID { get; set; }
        public string SMCREATORID { get; set; }
        public string MODIFIEDBY { get; set; }
        public string Created_Time { get; set; }
        public string Modified_Time { get; set; }

        public string Price_book_Owner { get; set; }
        public string Price_book_Name { get; set; }
        public string Active { get; set; }
        public string Created_By { get; set; }
        public string Pricing_Model { get; set; }
        public string Modified_By { get; set; }
        public string Description { get; set; }
        public string Pricing_details { get; set; }

        public string Model_Id { get; set; }
        public string From_Range { get; set; }
        public string To_Range { get; set; }
        public string Discount { get; set; }
    }
}
