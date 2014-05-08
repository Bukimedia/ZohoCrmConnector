using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZohoCrmConnector.Entities;

namespace ZohoCrmConnector.Factories
{
    public class VendorsFactory : RestSharpFactory
    {
        public VendorsFactory(string userToken)
            : base(userToken)
        {
            module = "Vendors";
        }

        public List<Vendors> getMyRecords()
        {
            return this.getMyRecords<List<Vendors>>(module);
        }

        public List<Vendors> getMyRecords(Dictionary<string, string> parameters)
        {
            return this.getMyRecords<List<Vendors>>(module, parameters);
        }

        public List<Vendors> getRecords()
        {
            return this.getRecords<List<Vendors>>(module);
        }

        public List<Vendors> getRecords(Dictionary<string, string> parameters)
        {
            return this.getRecords<List<Vendors>>(module, parameters);
        }

        public Vendors getRecordById(long VendorId)
        {
            return this.getRecordById<List<Vendors>>(module, VendorId)[0];
        }

        public Vendors getRecordById(long VendorId, Dictionary<string, string> parameters)
        {
            return this.getRecordById<Vendors>(module, VendorId, parameters);
        }

        public List<Vendors> getCVRecords(String cvName)
        {
            return this.getCVRecords<List<Vendors>>(module, cvName);
        }

        public List<Vendors> getCVRecords(String cvName, Dictionary<string, string> parameters)
        {
            return this.getCVRecords<List<Vendors>>(module, cvName, parameters);
        }

        public bool insertRecords(List<Vendors> listVendors)
        {
            return this.insertRecords(module, listVendors);
        }

        public bool insertRecords(List<Vendors> listVendors, Dictionary<string, string> parameters)
        {
            return this.insertRecords(module, listVendors, parameters);
        }

        public bool updateRecords(long VendorId, List<Vendors> listVendors)
        {
            return this.updateRecords(module, VendorId, listVendors);
        }

        public bool updateRecords(long VendorId, List<Vendors> listVendors, Dictionary<string, string> parameters)
        {
            return this.updateRecords(module, VendorId, listVendors, parameters);
        }

        public List<Vendors> getSearchRecords(string searchCondition)
        {
            return this.getSearchRecords<List<Vendors>>(module, searchCondition);
        }

        public List<Vendors> getSearchRecords(string searchCondition, Dictionary<string, string> parameters)
        {
            return this.getSearchRecords<List<Vendors>>(module, searchCondition, parameters);
        }

        public List<Vendors> getSearchRecordsByPDC(string searchColumn, string searchValue)
        {
            return this.getSearchRecordsByPDC<List<Vendors>>(module, searchColumn, searchValue);
        }

        public List<Vendors> getSearchRecordsByPDC(string searchColumn, string searchValue, Dictionary<string, string> parameters)
        {
            return this.getSearchRecordsByPDC<List<Vendors>>(module, searchColumn, searchValue, parameters);
        }

        public bool deleteRecords(long VendorId)
        {
            return this.deleteRecords(module, VendorId);
        }

        public List<Vendors> getRelatedRecords(long id, string parentModule)
        {
            return this.getRelatedRecords<List<Vendors>>(module, id, parentModule);
        }

        public List<Vendors> getRelatedRecords(long id, string parentModule, Dictionary<string, string> parameters)
        {
            return this.getRelatedRecords<List<Vendors>>(module, id, parentModule, parameters);
        }

        public Fields getFields()
        {
            return this.getFields(module);
        }

        public bool uploadFile(long VendorId, string filePath)
        {
            return this.uploadFile(module, VendorId, filePath);
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
