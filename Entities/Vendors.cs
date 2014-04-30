using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZohoCrmConnector.Entities
{
    class Vendors
    {
        public string VENDORID { get; set; }
        public string SMOWNERID { get; set; }
        public string SMCREATORID { get; set; }
        public string MODIFIEDBY { get; set; }
        public string Created_Time { get; set; }
        public string Modified_Time { get; set; }

        public string Vendor_Owner { get; set; }
        public string Vendor_Name { get; set; }
        public string Phone { get; set; }
        public string E_mail { get; set; }
        public string Website { get; set; }
        public string GL_Account { get; set; }
        public string Category { get; set; }
        public string Created_By { get; set; }
        public string Modified_By { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip_Code { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
    }
}
