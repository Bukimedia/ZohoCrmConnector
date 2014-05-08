using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZohoCrmConnector.Entities;

namespace ZohoCrmConnector.Factories
{
    public class QuotesFactory : RestSharpFactory
    {
        public QuotesFactory(string userToken)
            : base(userToken)
        {
            module = "Quotes";
        }

        public List<Quotes> getMyRecords()
        {
            return this.getMyRecords<List<Quotes>>(module);
        }

        public List<Quotes> getMyRecords(Dictionary<string, string> parameters)
        {
            return this.getMyRecords<List<Quotes>>(module, parameters);
        }

        public List<Quotes> getRecords()
        {
            return this.getRecords<List<Quotes>>(module);
        }

        public List<Quotes> getRecords(Dictionary<string, string> parameters)
        {
            return this.getRecords<List<Quotes>>(module, parameters);
        }

        public Quotes getRecordById(long QuoteId)
        {
            return this.getRecordById<List<Quotes>>(module, QuoteId)[0];
        }

        public Quotes getRecordById(long QuoteId, Dictionary<string, string> parameters)
        {
            return this.getRecordById<Quotes>(module, QuoteId, parameters);
        }

        public List<Quotes> getCVRecords(String cvName)
        {
            return this.getCVRecords<List<Quotes>>(module, cvName);
        }

        public List<Quotes> getCVRecords(String cvName, Dictionary<string, string> parameters)
        {
            return this.getCVRecords<List<Quotes>>(module, cvName, parameters);
        }

        public bool insertRecords(List<Quotes> listQuotes)
        {
            return this.insertRecords(module, listQuotes);
        }

        public bool insertRecords(List<Quotes> listQuotes, Dictionary<string, string> parameters)
        {
            return this.insertRecords(module, listQuotes, parameters);
        }

        public bool updateRecords(long QuoteId, List<Quotes> listQuotes)
        {
            return this.updateRecords(module, QuoteId, listQuotes);
        }

        public bool updateRecords(long QuoteId, List<Quotes> listQuotes, Dictionary<string, string> parameters)
        {
            return this.updateRecords(module, QuoteId, listQuotes, parameters);
        }

        public List<Quotes> getSearchRecords(string searchCondition)
        {
            return this.getSearchRecords<List<Quotes>>(module, searchCondition);
        }

        public List<Quotes> getSearchRecords(string searchCondition, Dictionary<string, string> parameters)
        {
            return this.getSearchRecords<List<Quotes>>(module, searchCondition, parameters);
        }

        public List<Quotes> getSearchRecordsByPDC(string searchColumn, string searchValue)
        {
            return this.getSearchRecordsByPDC<List<Quotes>>(module, searchColumn, searchValue);
        }

        public List<Quotes> getSearchRecordsByPDC(string searchColumn, string searchValue, Dictionary<string, string> parameters)
        {
            return this.getSearchRecordsByPDC<List<Quotes>>(module, searchColumn, searchValue, parameters);
        }

        public bool deleteRecords(long QuoteId)
        {
            return this.deleteRecords(module, QuoteId);
        }

        public List<Quotes> getRelatedRecords(long id, string parentModule)
        {
            return this.getRelatedRecords<List<Quotes>>(module, id, parentModule);
        }

        public List<Quotes> getRelatedRecords(long id, string parentModule, Dictionary<string, string> parameters)
        {
            return this.getRelatedRecords<List<Quotes>>(module, id, parentModule, parameters);
        }

        public Fields getFields()
        {
            return this.getFields(module);
        }

        public bool uploadFile(long QuoteId, string filePath)
        {
            return this.uploadFile(module, QuoteId, filePath);
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
