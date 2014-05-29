using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZohoCrmConnector.Entities;

namespace ZohoCrmConnector.Factories
{
    public class NotesFactory : RestSharpFactory
    {
        public NotesFactory(string userToken)
            : base(userToken)
        {
            module = "Notes";
        }

        /// <summary>
        /// To get records related to a primary module
        /// </summary>
        /// <param name="id">The id of the record for which you want to fetch related records</param>
        /// <param name="parentModule">Module for which you want to fetch the related records</param>
        /// <returns>List of Notes</returns>
        public List<Notes> getRelatedRecords(long id, string parentModule)
        {
            return this.getRelatedRecords<List<Notes>>(module, id, parentModule);
        }

        /// <summary>
        /// To get records related to a primary module
        /// </summary>
        /// <param name="id">The id of the record for which you want to fetch related records</param>
        /// <param name="parentModule">Module for which you want to fetch the related records</param>
        /// <param name="parameters">
        /// Dictionary:                 key: fromIndex, 	    value: (Default value: 1)
        ///                             key: toIndex,           value: (Default value:20 / Maximum value:200)
        ///                             key: newFormat	        value: (1 or 2)	newFormat=1: To exclude fields with "null" values while fetching data from your CRM account.</param>
        /// <returns>List of Notes</returns>
        public List<Notes> getRelatedRecords(long id, string parentModule, Dictionary<string, string> parameters)
        {
            return this.getRelatedRecords<List<Notes>>(module, id, parentModule, parameters);
        }
    }
}