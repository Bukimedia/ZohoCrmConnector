using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZohoCrmConnector.Entities;

namespace ZohoCrmConnector.Factories
{
    public class AttachmentsFactory : RestSharpFactory
    {
        public AttachmentsFactory(string userToken)
            : base(userToken)
        {
            module = "Attachments";
        }

        public List<Attachments> getRelatedRecords(long id, string parentModule)
        {
            return this.getRelatedRecords<List<Attachments>>(module, id, parentModule);
        }

        public List<Attachments> getRelatedRecords(long id, string parentModule, Dictionary<string, string> parameters)
        {
            return this.getRelatedRecords<List<Attachments>>(module, id, parentModule, parameters);
        }
    }
}