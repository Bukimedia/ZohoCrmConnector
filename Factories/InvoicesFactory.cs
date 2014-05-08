using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZohoCrmConnector.Entities;

namespace ZohoCrmConnector.Factories
{
    public class InvoicesFactory : RestSharpFactory
    {
        public InvoicesFactory(string userToken)
            : base(userToken)
        {
            module = "Invoices";
        }

        public List<Invoices> getMyRecords()
        {
            return this.getMyRecords<List<Invoices>>(module);
        }

        public List<Invoices> getMyRecords(Dictionary<string, string> parameters)
        {
            return this.getMyRecords<List<Invoices>>(module, parameters);
        }

        public List<Invoices> getRecords()
        {
            return this.getRecords<List<Invoices>>(module);
        }

        public List<Invoices> getRecords(Dictionary<string, string> parameters)
        {
            return this.getRecords<List<Invoices>>(module, parameters);
        }

        public Invoices getRecordById(long InvoiceId)
        {
            return this.getRecordById<List<Invoices>>(module, InvoiceId)[0];
        }

        public Invoices getRecordById(long InvoiceId, Dictionary<string, string> parameters)
        {
            return this.getRecordById<Invoices>(module, InvoiceId, parameters);
        }

        public List<Invoices> getCVRecords(String cvName)
        {
            return this.getCVRecords<List<Invoices>>(module, cvName);
        }

        public List<Invoices> getCVRecords(String cvName, Dictionary<string, string> parameters)
        {
            return this.getCVRecords<List<Invoices>>(module, cvName, parameters);
        }

        public bool insertRecords(List<Invoices> listInvoices)
        {
            return this.insertRecords(module, listInvoices);
        }

        public bool insertRecords(List<Invoices> listInvoices, Dictionary<string, string> parameters)
        {
            return this.insertRecords(module, listInvoices, parameters);
        }

        public bool updateRecords(long InvoiceId, List<Invoices> listInvoices)
        {
            return this.updateRecords(module, InvoiceId, listInvoices);
        }

        public bool updateRecords(long InvoiceId, List<Invoices> listInvoices, Dictionary<string, string> parameters)
        {
            return this.updateRecords(module, InvoiceId, listInvoices, parameters);
        }

        public List<Invoices> getSearchRecords(string searchCondition)
        {
            return this.getSearchRecords<List<Invoices>>(module, searchCondition);
        }

        public List<Invoices> getSearchRecords(string searchCondition, Dictionary<string, string> parameters)
        {
            return this.getSearchRecords<List<Invoices>>(module, searchCondition, parameters);
        }

        public List<Invoices> getSearchRecordsByPDC(string searchColumn, string searchValue)
        {
            return this.getSearchRecordsByPDC<List<Invoices>>(module, searchColumn, searchValue);
        }

        public List<Invoices> getSearchRecordsByPDC(string searchColumn, string searchValue, Dictionary<string, string> parameters)
        {
            return this.getSearchRecordsByPDC<List<Invoices>>(module, searchColumn, searchValue, parameters);
        }

        public bool deleteRecords(long InvoiceId)
        {
            return this.deleteRecords(module, InvoiceId);
        }

        public List<Invoices> getRelatedRecords(long id, string parentModule)
        {
            return this.getRelatedRecords<List<Invoices>>(module, id, parentModule);
        }

        public List<Invoices> getRelatedRecords(long id, string parentModule, Dictionary<string, string> parameters)
        {
            return this.getRelatedRecords<List<Invoices>>(module, id, parentModule, parameters);
        }

        public Fields getFields()
        {
            return this.getFields(module);
        }

        public bool uploadFile(long InvoiceId, string filePath)
        {
            return this.uploadFile(module, InvoiceId, filePath);
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
