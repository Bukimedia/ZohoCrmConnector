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

        public List<Notes> getRelatedRecords(long id, string parentModule)
        {
            return this.getRelatedRecords<List<Notes>>(module, id, parentModule);
        }

        public List<Notes> getRelatedRecords(long id, string parentModule, Dictionary<string, string> parameters)
        {
            return this.getRelatedRecords<List<Notes>>(module, id, parentModule, parameters);
        }
    }
}