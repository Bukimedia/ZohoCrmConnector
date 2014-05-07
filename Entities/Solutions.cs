using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZohoCrmConnector.Entities
{
    public class Solutions
    {
        public string SOLUTIONID { get; set; }
        public string SMOWNERID { get; set; }
        public string SMCREATORID { get; set; }
        public string MODIFIEDBY { get; set; }
        public string Created_Time { get; set; }
        public string Modified_Time { get; set; }

        public string Solution_Number { get; set; }
        public string Solution_Owner { get; set; }
        public string Solution_Title { get; set; }
        public string Status { get; set; }
        public string PRODUCTID { get; set; }
        public string Product_Name { get; set; }
        public string Created_By { get; set; }
        public string Modified_By { get; set; }
        public string No_of_comments { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string Add_Comment { get; set; }
    }
}
