using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZohoCrmConnector.Entities;

namespace ZohoCrmConnector.Factories
{
    public class PriceBooksFactory : RestSharpFactory
    {
        public PriceBooksFactory(string userToken)
            : base(userToken)
        {
            module = "PriceBooks";
        }

        public List<PriceBooks> getMyRecords()
        {
            return this.getMyRecords<List<PriceBooks>>(module);
        }

        public List<PriceBooks> getMyRecords(Dictionary<string, string> parameters)
        {
            return this.getMyRecords<List<PriceBooks>>(module, parameters);
        }

        public List<PriceBooks> getRecords()
        {
            return this.getRecords<List<PriceBooks>>(module);
        }

        public List<PriceBooks> getRecords(Dictionary<string, string> parameters)
        {
            return this.getRecords<List<PriceBooks>>(module, parameters);
        }

        public PriceBooks getRecordById(long PriceBookId)
        {
            return this.getRecordById<List<PriceBooks>>(module, PriceBookId)[0];
        }

        public PriceBooks getRecordById(long PriceBookId, Dictionary<string, string> parameters)
        {
            return this.getRecordById<PriceBooks>(module, PriceBookId, parameters);
        }

        public List<PriceBooks> getCVRecords(String cvName)
        {
            return this.getCVRecords<List<PriceBooks>>(module, cvName);
        }

        public List<PriceBooks> getCVRecords(String cvName, Dictionary<string, string> parameters)
        {
            return this.getCVRecords<List<PriceBooks>>(module, cvName, parameters);
        }

        public bool insertRecords(List<PriceBooks> listPriceBooks)
        {
            return this.insertRecords(module, listPriceBooks);
        }

        public bool insertRecords(List<PriceBooks> listPriceBooks, Dictionary<string, string> parameters)
        {
            return this.insertRecords(module, listPriceBooks, parameters);
        }

        public bool updateRecords(long PriceBookId, List<PriceBooks> listPriceBooks)
        {
            return this.updateRecords(module, PriceBookId, listPriceBooks);
        }

        public bool updateRecords(long PriceBookId, List<PriceBooks> listPriceBooks, Dictionary<string, string> parameters)
        {
            return this.updateRecords(module, PriceBookId, listPriceBooks, parameters);
        }

        public List<PriceBooks> getSearchRecords(string searchCondition)
        {
            return this.getSearchRecords<List<PriceBooks>>(module, searchCondition);
        }

        public List<PriceBooks> getSearchRecords(string searchCondition, Dictionary<string, string> parameters)
        {
            return this.getSearchRecords<List<PriceBooks>>(module, searchCondition, parameters);
        }

        public List<PriceBooks> getSearchRecordsByPDC(string searchColumn, string searchValue)
        {
            return this.getSearchRecordsByPDC<List<PriceBooks>>(module, searchColumn, searchValue);
        }

        public List<PriceBooks> getSearchRecordsByPDC(string searchColumn, string searchValue, Dictionary<string, string> parameters)
        {
            return this.getSearchRecordsByPDC<List<PriceBooks>>(module, searchColumn, searchValue, parameters);
        }

        public bool deleteRecords(long PriceBookId)
        {
            return this.deleteRecords(module, PriceBookId);
        }

        public List<PriceBooks> getRelatedRecords(long id, string parentModule)
        {
            return this.getRelatedRecords<List<PriceBooks>>(module, id, parentModule);
        }

        public List<PriceBooks> getRelatedRecords(long id, string parentModule, Dictionary<string, string> parameters)
        {
            return this.getRelatedRecords<List<PriceBooks>>(module, id, parentModule, parameters);
        }

        public Fields getFields()
        {
            return this.getFields(module);
        }

        public bool uploadFile(long PriceBookId, string filePath)
        {
            return this.uploadFile(module, PriceBookId, filePath);
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
