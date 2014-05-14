using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZohoCrmConnector.Entities;

namespace ZohoCrmConnector.Factories
{
    public class CasesFactory : RestSharpFactory
    {
        public CasesFactory(string userToken)
            : base(userToken)
        {
            module = "Cases";
        }

        public List<Cases> getMyRecords()
        {
            return this.getMyRecords<List<Cases>>(module);
        }

        public List<Cases> getMyRecords(Dictionary<string, string> parameters)
        {
            return this.getMyRecords<List<Cases>>(module, parameters);
        }

        public List<Cases> getRecords()
        {
            return this.getRecords<List<Cases>>(module);
        }

        public List<Cases> getRecords(Dictionary<string, string> parameters)
        {
            return this.getRecords<List<Cases>>(module, parameters);
        }

        public Cases getRecordById(long CaseId)
        {
            return this.getRecordById<List<Cases>>(module, CaseId)[0];
        }

        public Cases getRecordById(long CaseId, Dictionary<string, string> parameters)
        {
            return this.getRecordById<Cases>(module, CaseId, parameters);
        }

        public List<Cases> getCVRecords(String cvName)
        {
            return this.getCVRecords<List<Cases>>(module, cvName);
        }

        public List<Cases> getCVRecords(String cvName, Dictionary<string, string> parameters)
        {
            return this.getCVRecords<List<Cases>>(module, cvName, parameters);
        }

        public bool insertRecords(List<Cases> listCases)
        {
            return this.insertRecords(module, listCases);
        }

        public bool insertRecords(List<Cases> listCases, Dictionary<string, string> parameters)
        {
            return this.insertRecords(module, listCases, parameters);
        }

        public bool updateRecords(long CaseId, Cases Case)
        {
            List<Cases> listCases = new List<Cases>();
            listCases.Add(Case);
            return this.updateRecords(module, CaseId, listCases);
        }

        public bool updateRecords(long CaseId, Cases Case, Dictionary<string, string> parameters)
        {
            List<Cases> listCases = new List<Cases>();
            listCases.Add(Case);
            return this.updateRecords(module, CaseId, listCases, parameters);
        }

        public List<Cases> getSearchRecords(string searchCondition)
        {
            return this.getSearchRecords<List<Cases>>(module, searchCondition);
        }

        public List<Cases> getSearchRecords(string searchCondition, Dictionary<string, string> parameters)
        {
            return this.getSearchRecords<List<Cases>>(module, searchCondition, parameters);
        }

        public List<Cases> getSearchRecordsByPDC(string searchColumn, string searchValue)
        {
            return this.getSearchRecordsByPDC<List<Cases>>(module, searchColumn, searchValue);
        }

        public List<Cases> getSearchRecordsByPDC(string searchColumn, string searchValue, Dictionary<string, string> parameters)
        {
            return this.getSearchRecordsByPDC<List<Cases>>(module, searchColumn, searchValue, parameters);
        }

        public bool deleteRecords(long CaseId)
        {
            return this.deleteRecords(module, CaseId);
        }

        public List<Cases> getRelatedRecords(long id, string parentModule)
        {
            return this.getRelatedRecords<List<Cases>>(module, id, parentModule);
        }

        public List<Cases> getRelatedRecords(long id, string parentModule, Dictionary<string, string> parameters)
        {
            return this.getRelatedRecords<List<Cases>>(module, id, parentModule, parameters);
        }

        public Fields getFields()
        {
            return this.getFields(module);
        }

        public bool uploadFile(long CaseId, string filePath)
        {
            return this.uploadFile(module, CaseId, filePath);
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
