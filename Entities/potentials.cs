using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZohoCrmConnector.Entities
{
    class potentials
    {
        public long leadID { get; set; }
        public long smowerID { get; set; }
        public long potentialOwner { get; set; }
        public string salutation { get; set; }
        public string firstName { get; set; }
        public string title { get; set; }
        public string lastName { get; set; }
        public string company { get; set; }
        public byte leadSource { get; set; }
        public byte industry { get; set; }
        public int annualRevenue { get; set; }
        public string phone { get; set; }
        public string mobile { get; set; }
        public string fax { get; set; }
        public string email { get; set; }
        public string emailSec { get; set; }
        public string skypeID { get; set; }
        public string website { get; set; }
        public byte leadStatus { get; set; }
        public byte rating { get; set; }
        public int numEmployees { get; set; }
        public bool emailOptOut { get; set; }
        public long campaingSource { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zioCode { get; set; }
        public string country { get; set; }
        public string description { get; set; }


        /*
Potential Owner	Potential Owner	Select the name of the user to whom the potential is assigned.	Lookup	 
Potential Name*	Potential Name*	Specify name of the potential. This field is mandatory.	Text box	Alphanumeric(120)
Account Name*	Account Name*	Select name of the account to which potential has to be created. This field is mandatory.	Lookup	-
Type	Type	Select the type of potential (New Business or Existing Business) from the drop-down list.	Pick list	-
Lead Source	Lead Source	Select the lead source from the drop-down list	Pick list	-
Campaign Source	Campaign Source	Select the campaign related to the contact.	Lookup	-
Contact Name	Contact Name	Select the contact related to the Potential.	Lookup	 
Amount	Amount	Specify the amount that can be expected after closing the potential.	Currency	 
Closing Date*	Closing Date*	Specify or select the expected close date. This field is mandatory.	Date format	-
Next Step	Next Step	Specify the next step of the sales process.	Text box	Alphanumeric(100)
Stage*	Stage*	Select the sales stage from the drop-down list. This field is mandatory.	Pick list	-
Probability	Probability	Specify the probability of closing an potential.	Number	 
Expected Revenue	Expected Revenue	Calculated based on the Amount and potential Stage that you specify	Currency	 
Description	Description	Specify any other details about potential.	Text area (long text)	32000 characters*/
    }
}
