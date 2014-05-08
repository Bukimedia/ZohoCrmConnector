using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZohoCrmConnector.Entities;

namespace ZohoCrmConnector.Factories
{
    public class AccountsFactory : RestSharpFactory
    {
        public AccountsFactory(string userToken)
            : base(userToken)
        {
            module="Accounts";
        }

        public List<Accounts> getMyRecords()
        {
            return this.getMyRecords<List<Accounts>>(module);
        }

        public List<Accounts> getMyRecords(Dictionary<string, string> parameters)
        {
            return this.getMyRecords<List<Accounts>>(module, parameters);
        }

        public List<Accounts> getRecords()
        {
            return this.getRecords<List<Accounts>>(module);
        }

        public List<Accounts> getRecords(Dictionary<string, string> parameters)
        {
            return this.getRecords<List<Accounts>>(module, parameters);
        }

        public Accounts getRecordById(long AccountId)
        {
            return this.getRecordById<List<Accounts>>(module, AccountId)[0];
        }

        public Accounts getRecordById(long AccountId, Dictionary<string, string> parameters)
        {
            return this.getRecordById<Accounts>(module, AccountId, parameters);
        }

        public List<Accounts> getCVRecords(String cvName)
        {
            return this.getCVRecords<List<Accounts>>(module, cvName);
        }

        public List<Accounts> getCVRecords(String cvName, Dictionary<string, string> parameters)
        {
            return this.getCVRecords<List<Accounts>>(module, cvName, parameters);
        }

        public bool insertRecords(List<Accounts> listAccounts)
        {
            return this.insertRecords(module, listAccounts);
        }

        public bool insertRecords(List<Accounts> listAccounts, Dictionary<string, string> parameters)
        {
            return this.insertRecords(module, listAccounts, parameters);
        }

        public bool updateRecords(long AccountId, List<Accounts> listAccounts)
        {
            return this.updateRecords(module, AccountId, listAccounts);
        }

        public bool updateRecords(long AccountId, List<Accounts> listAccounts, Dictionary<string, string> parameters)
        {
            return this.updateRecords(module, AccountId, listAccounts, parameters);
        }

        public List<Accounts> getSearchRecords(string searchCondition)
        {
            return this.getSearchRecords<List<Accounts>>(module, searchCondition);
        }

        public List<Accounts> getSearchRecords(string searchCondition, Dictionary<string, string> parameters)
        {
            return this.getSearchRecords<List<Accounts>>(module, searchCondition, parameters);
        }

        public List<Accounts> getSearchRecordsByPDC(string searchColumn, string searchValue)
        {
            return this.getSearchRecordsByPDC<List<Accounts>>(module, searchColumn, searchValue);
        }

        public List<Accounts> getSearchRecordsByPDC(string searchColumn, string searchValue, Dictionary<string, string> parameters)
        {
            return this.getSearchRecordsByPDC<List<Accounts>>(module, searchColumn, searchValue, parameters);
        }

        public bool deleteRecords(long AccountId)
        {
            return this.deleteRecords(module, AccountId);
        }

        public List<Accounts> getRelatedRecords(long id, string parentModule)
        {
            return this.getRelatedRecords<List<Accounts>>(module, id, parentModule);
        }

        public List<Accounts> getRelatedRecords(long id, string parentModule, Dictionary<string, string> parameters)
        {
            return this.getRelatedRecords<List<Accounts>>(module, id, parentModule, parameters);
        }

        public Fields getFields()
        {
            return this.getFields(module);
        }

        public bool uploadFile(long AccountId, string filePath)
        {
            return this.uploadFile(module, AccountId, filePath);
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
