using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZohoCrmConnector.Entities;

namespace ZohoCrmConnector.Factories
{
    public class CallsFactory : RestSharpFactory
    {
        public CallsFactory(string userToken)
            : base(userToken)
        {
            module = "Calls";
        }

        public List<Calls> getMyRecords()
        {
            return this.getMyRecords<List<Calls>>(module);
        }

        public List<Calls> getMyRecords(Dictionary<string, string> parameters)
        {
            return this.getMyRecords<List<Calls>>(module, parameters);
        }

        public List<Calls> getRecords()
        {
            return this.getRecords<List<Calls>>(module);
        }

        public List<Calls> getRecords(Dictionary<string, string> parameters)
        {
            return this.getRecords<List<Calls>>(module, parameters);
        }

        public Calls getRecordById(long CallId)
        {
            return this.getRecordById<List<Calls>>(module, CallId)[0];
        }

        public Calls getRecordById(long CallId, Dictionary<string, string> parameters)
        {
            return this.getRecordById<Calls>(module, CallId, parameters);
        }

        public List<Calls> getCVRecords(String cvName)
        {
            return this.getCVRecords<List<Calls>>(module, cvName);
        }

        public List<Calls> getCVRecords(String cvName, Dictionary<string, string> parameters)
        {
            return this.getCVRecords<List<Calls>>(module, cvName, parameters);
        }

        public bool insertRecords(List<Calls> listCalls)
        {
            return this.insertRecords(module, listCalls);
        }

        public bool insertRecords(List<Calls> listCalls, Dictionary<string, string> parameters)
        {
            return this.insertRecords(module, listCalls, parameters);
        }

        public bool updateRecords(long CallId, Calls Call)
        {
            List<Calls> listCalls = new List<Calls>();
            listCalls.Add(Call);
            return this.updateRecords(module, CallId, listCalls);
        }

        public bool updateRecords(long CallId, Calls Call, Dictionary<string, string> parameters)
        {
            List<Calls> listCalls = new List<Calls>();
            listCalls.Add(Call);
            return this.updateRecords(module, CallId, listCalls, parameters);
        }

        public List<Calls> getSearchRecords(string searchCondition)
        {
            return this.getSearchRecords<List<Calls>>(module, searchCondition);
        }

        public List<Calls> getSearchRecords(string searchCondition, Dictionary<string, string> parameters)
        {
            return this.getSearchRecords<List<Calls>>(module, searchCondition, parameters);
        }

        public List<Calls> getSearchRecordsByPDC(string searchColumn, string searchValue)
        {
            return this.getSearchRecordsByPDC<List<Calls>>(module, searchColumn, searchValue);
        }

        public List<Calls> getSearchRecordsByPDC(string searchColumn, string searchValue, Dictionary<string, string> parameters)
        {
            return this.getSearchRecordsByPDC<List<Calls>>(module, searchColumn, searchValue, parameters);
        }

        public bool deleteRecords(long CallId)
        {
            return this.deleteRecords(module, CallId);
        }

        public List<Calls> getRelatedRecords(long id, string parentModule)
        {
            return this.getRelatedRecords<List<Calls>>(module, id, parentModule);
        }

        public List<Calls> getRelatedRecords(long id, string parentModule, Dictionary<string, string> parameters)
        {
            return this.getRelatedRecords<List<Calls>>(module, id, parentModule, parameters);
        }

        public Fields getFields()
        {
            return this.getFields(module);
        }

        public bool uploadFile(long CallId, string filePath)
        {
            return this.uploadFile(module, CallId, filePath);
        }

        public bool downloadFile(long AttachmentId)
        {
            return this.downloadFile(module, AttachmentId, "");
        }

        public bool downloadFile(long AttachmentId, string filePath)
        {
            return this.downloadFile(module, AttachmentId, filePath);
        }

        public bool deleteFile(long AttachmentId)
        {
            return this.deleteFile(module, AttachmentId);
        }
    }
}
