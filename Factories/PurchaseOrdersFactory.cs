using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZohoCrmConnector.Entities;

namespace ZohoCrmConnector.Factories
{
    public class PurchaseOrdersFactory : RestSharpFactory
    {
        public PurchaseOrdersFactory(string userToken)
            : base(userToken)
        {
            module = "PurchaseOrders";
        }

        public List<PurchaseOrders> getMyRecords()
        {
            return this.getMyRecords<List<PurchaseOrders>>(module);
        }

        public List<PurchaseOrders> getMyRecords(Dictionary<string, string> parameters)
        {
            return this.getMyRecords<List<PurchaseOrders>>(module, parameters);
        }

        public List<PurchaseOrders> getRecords()
        {
            return this.getRecords<List<PurchaseOrders>>(module);
        }

        public List<PurchaseOrders> getRecords(Dictionary<string, string> parameters)
        {
            return this.getRecords<List<PurchaseOrders>>(module, parameters);
        }

        public PurchaseOrders getRecordById(long PurchaseOrderId)
        {
            return this.getRecordById<List<PurchaseOrders>>(module, PurchaseOrderId)[0];
        }

        public PurchaseOrders getRecordById(long PurchaseOrderId, Dictionary<string, string> parameters)
        {
            return this.getRecordById<PurchaseOrders>(module, PurchaseOrderId, parameters);
        }

        public List<PurchaseOrders> getCVRecords(String cvName)
        {
            return this.getCVRecords<List<PurchaseOrders>>(module, cvName);
        }

        public List<PurchaseOrders> getCVRecords(String cvName, Dictionary<string, string> parameters)
        {
            return this.getCVRecords<List<PurchaseOrders>>(module, cvName, parameters);
        }

        public bool insertRecords(List<PurchaseOrders> listPurchaseOrders)
        {
            return this.insertRecords(module, listPurchaseOrders);
        }

        public bool insertRecords(List<PurchaseOrders> listPurchaseOrders, Dictionary<string, string> parameters)
        {
            return this.insertRecords(module, listPurchaseOrders, parameters);
        }

        public bool updateRecords(long PurchaseOrderId, PurchaseOrders PurchaseOrder)
        {
            List<PurchaseOrders> listPurchaseOrders = new List<PurchaseOrders>();
            listPurchaseOrders.Add(PurchaseOrder);
            return this.updateRecords(module, PurchaseOrderId, listPurchaseOrders);
        }

        public bool updateRecords(long PurchaseOrderId, PurchaseOrders PurchaseOrder, Dictionary<string, string> parameters)
        {
            List<PurchaseOrders> listPurchaseOrders = new List<PurchaseOrders>();
            listPurchaseOrders.Add(PurchaseOrder);
            return this.updateRecords(module, PurchaseOrderId, listPurchaseOrders, parameters);
        }

        public List<PurchaseOrders> getSearchRecords(string searchCondition)
        {
            return this.getSearchRecords<List<PurchaseOrders>>(module, searchCondition);
        }

        public List<PurchaseOrders> getSearchRecords(string searchCondition, Dictionary<string, string> parameters)
        {
            return this.getSearchRecords<List<PurchaseOrders>>(module, searchCondition, parameters);
        }

        public List<PurchaseOrders> getSearchRecordsByPDC(string searchColumn, string searchValue)
        {
            return this.getSearchRecordsByPDC<List<PurchaseOrders>>(module, searchColumn, searchValue);
        }

        public List<PurchaseOrders> getSearchRecordsByPDC(string searchColumn, string searchValue, Dictionary<string, string> parameters)
        {
            return this.getSearchRecordsByPDC<List<PurchaseOrders>>(module, searchColumn, searchValue, parameters);
        }

        public bool deleteRecords(long PurchaseOrderId)
        {
            return this.deleteRecords(module, PurchaseOrderId);
        }

        public List<PurchaseOrders> getRelatedRecords(long id, string parentModule)
        {
            return this.getRelatedRecords<List<PurchaseOrders>>(module, id, parentModule);
        }

        public List<PurchaseOrders> getRelatedRecords(long id, string parentModule, Dictionary<string, string> parameters)
        {
            return this.getRelatedRecords<List<PurchaseOrders>>(module, id, parentModule, parameters);
        }

        public Fields getFields()
        {
            return this.getFields(module);
        }

        public bool uploadFile(long PurchaseOrderId, string filePath)
        {
            return this.uploadFile(module, PurchaseOrderId, filePath);
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
