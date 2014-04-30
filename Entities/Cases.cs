using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZohoCrmConnector.Entities
{
    class Cases
    {
        public string CASEID { get; set; }
        public string SMOWNERID { get; set; }
        public string SMCREATORID { get; set; }
        public string MODIFIEDBY { get; set; }
        public string Created_Time { get; set; }
        public string Modified_Time { get; set; }

        public string Case_Owner { get; set; }
        public string Status { get; set; }
        public string Product_Name { get; set; }
        public string Priority { get; set; }
        public string Type { get; set; }
        public string Case_Reason { get; set; }
        public string Case_Origin { get; set; }
        public string Subject { get; set; }
        public string Related_To { get; set; }
        public string Account_Name { get; set; }
        public string Reported_By { get; set; }
        public string Potential_Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Created_By { get; set; }
        public string Modified_By { get; set; }
        public string Description { get; set; }
        public string Internal_Comments { get; set; }
        public string Solution { get; set; }

        /* Don't made it yet
         * 
         * public List<Comments> List_Comments { get; set; }
         * 
         * <FL val="Comments">
         *      <comment no="1">
         *         <FL val="Comment Content">
         *             <![CDATA[ sfdgdgdfgdfg ]]>
         *         </FL>
         *         <FL val="Commented By">
         *            <![CDATA[ Marcos Torrente ]]>
         *         </FL>
         *         <FL val="Commented Time">Apr 30, 2014 10:43:31 AM</FL>
         *     </comment>
         * </FL>
         * 
         * */

        public string Case_Number { get; set; }
        public string PRODUCTID { get; set; }
        public string WHOID { get; set; }
        public string No_of_comments { get; set; }
        public string ACCOUNTID { get; set; }
        public string POTENTIALID { get; set; }
    }
}
