using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZohoCrmConnector.Entities
{
    public class Notes
    {
        public string id { get; set; }
        public string Title { get; set; }
        public string Note_Content { get; set; }
        public string SMOWNERID { get; set; }
        public string SMCREATORID { get; set; }
        public string Created_Time { get; set; }
        public string MODIFIEDBY { get; set; }
        public string Modified_By { get; set; }
        public string Modified_Time { get; set; }
        public string ISVOICENOTES { get; set; }
    }
}
