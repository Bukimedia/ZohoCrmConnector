using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZohoCrmConnector.Entities;

namespace ZohoCrmConnector.Factories
{
    public class SalesOrdersFactory : RestSharpFactory
    {
        public SalesOrdersFactory(string userToken)
            : base(userToken)
        {
            module = "SalesOrders";
        }

        public List<SalesOrders> getMyRecords()
        {
            return this.getMyRecords<List<SalesOrders>>(module);
        }

        public List<SalesOrders> getMyRecords(Dictionary<string, string> parameters)
        {
            return this.getMyRecords<List<SalesOrders>>(module, parameters);
        }

        public List<SalesOrders> getRecords()
        {
            return this.getRecords<List<SalesOrders>>(module);
        }

        public List<SalesOrders> getRecords(Dictionary<string, string> parameters)
        {
            return this.getRecords<List<SalesOrders>>(module, parameters);
        }

        public SalesOrders getRecordById(long SalesOrderId)
        {
            return this.getRecordById<List<SalesOrders>>(module, SalesOrderId)[0];
        }

        public SalesOrders getRecordById(long SalesOrderId, Dictionary<string, string> parameters)
        {
            return this.getRecordById<SalesOrders>(module, SalesOrderId, parameters);
        }

        public List<SalesOrders> getCVRecords(String cvName)
        {
            return this.getCVRecords<List<SalesOrders>>(module, cvName);
        }

        public List<SalesOrders> getCVRecords(String cvName, Dictionary<string, string> parameters)
        {
            return this.getCVRecords<List<SalesOrders>>(module, cvName, parameters);
        }

        public bool insertRecords(List<SalesOrders> listSalesOrders)
        {
            return this.insertRecords(module, listSalesOrders);
        }

        public bool insertRecords(List<SalesOrders> listSalesOrders, Dictionary<string, string> parameters)
        {
            return this.insertRecords(module, listSalesOrders, parameters);
        }

        public bool updateRecords(long SalesOrderId, List<SalesOrders> listSalesOrders)
        {
            return this.updateRecords(module, SalesOrderId, listSalesOrders);
        }

        public bool updateRecords(long SalesOrderId, List<SalesOrders> listSalesOrders, Dictionary<string, string> parameters)
        {
            return this.updateRecords(module, SalesOrderId, listSalesOrders, parameters);
        }

        public List<SalesOrders> getSearchRecords(string searchCondition)
        {
            return this.getSearchRecords<List<SalesOrders>>(module, searchCondition);
        }

        public List<SalesOrders> getSearchRecords(string searchCondition, Dictionary<string, string> parameters)
        {
            return this.getSearchRecords<List<SalesOrders>>(module, searchCondition, parameters);
        }

        public List<SalesOrders> getSearchRecordsByPDC(string searchColumn, string searchValue)
        {
            return this.getSearchRecordsByPDC<List<SalesOrders>>(module, searchColumn, searchValue);
        }

        public List<SalesOrders> getSearchRecordsByPDC(string searchColumn, string searchValue, Dictionary<string, string> parameters)
        {
            return this.getSearchRecordsByPDC<List<SalesOrders>>(module, searchColumn, searchValue, parameters);
        }

        public bool deleteRecords(long SalesOrderId)
        {
            return this.deleteRecords(module, SalesOrderId);
        }

        public List<SalesOrders> getRelatedRecords(long id, string parentModule)
        {
            return this.getRelatedRecords<List<SalesOrders>>(module, id, parentModule);
        }

        public List<SalesOrders> getRelatedRecords(long id, string parentModule, Dictionary<string, string> parameters)
        {
            return this.getRelatedRecords<List<SalesOrders>>(module, id, parentModule, parameters);
        }

        public Fields getFields()
        {
            return this.getFields(module);
        }

        public bool uploadFile(long SalesOrderId, string filePath)
        {
            return this.uploadFile(module, SalesOrderId, filePath);
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
