using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZohoCrmConnector.Entities
{
    public class Attachments
    {
        public string id { get; set; }
        public string File_Name { get; set; }
        public string Size { get; set; }
        public string Modified_Time { get; set; }
        public string SMOWNERID { get; set; }
        public string Attached_By { get; set; }
    }
}