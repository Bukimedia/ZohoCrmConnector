using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZohoCrmConnector.Entities;

namespace ZohoCrmConnector.Factories
{
    public class LeadsFactory : RestSharpFactory
    {
        public LeadsFactory(string userToken)
            : base(userToken)
        {
            module = "Leads";
        }

        public List<Leads> getMyRecords()
        {
            return this.getMyRecords<List<Leads>>(module);
        }

        public List<Leads> getMyRecords(Dictionary<string, string> parameters)
        {
            return this.getMyRecords<List<Leads>>(module, parameters);
        }

        public List<Leads> getRecords()
        {
            return this.getRecords<List<Leads>>(module);
        }

        public List<Leads> getRecords(Dictionary<string, string> parameters)
        {
            return this.getRecords<List<Leads>>(module, parameters);
        }

        public Leads getRecordById(long LeadId)
        {
            return this.getRecordById<List<Leads>>(module, LeadId)[0];
        }

        public Leads getRecordById(long LeadId, Dictionary<string, string> parameters)
        {
            return this.getRecordById<Leads>(module, LeadId, parameters);
        }

        public List<Leads> getCVRecords(String cvName)
        {
            return this.getCVRecords<List<Leads>>(module, cvName);
        }

        public List<Leads> getCVRecords(String cvName, Dictionary<string, string> parameters)
        {
            return this.getCVRecords<List<Leads>>(module, cvName, parameters);
        }

        public bool insertRecords(List<Leads> listLeads)
        {
            return this.insertRecords(module, listLeads);
        }

        public bool insertRecords(List<Leads> listLeads, Dictionary<string, string> parameters)
        {
            return this.insertRecords(module, listLeads, parameters);
        }

        public bool updateRecords(long LeadId, Leads Lead)
        {
            List<Leads> listLeads = new List<Leads>();
            listLeads.Add(Lead);
            return this.updateRecords(module, LeadId, listLeads);
        }

        public bool updateRecords(long LeadId, Leads Lead, Dictionary<string, string> parameters)
        {
            List<Leads> listLeads = new List<Leads>();
            listLeads.Add(Lead);
            return this.updateRecords(module, LeadId, listLeads, parameters);
        }

        public List<Leads> getSearchRecords(string searchCondition)
        {
            return this.getSearchRecords<List<Leads>>(module, searchCondition);
        }

        public List<Leads> getSearchRecords(string searchCondition, Dictionary<string, string> parameters)
        {
            return this.getSearchRecords<List<Leads>>(module, searchCondition, parameters);
        }

        public List<Leads> getSearchRecordsByPDC(string searchColumn, string searchValue)
        {
            return this.getSearchRecordsByPDC<List<Leads>>(module, searchColumn, searchValue);
        }

        public List<Leads> getSearchRecordsByPDC(string searchColumn, string searchValue, Dictionary<string, string> parameters)
        {
            return this.getSearchRecordsByPDC<List<Leads>>(module, searchColumn, searchValue, parameters);
        }

        public bool deleteRecords(long LeadId)
        {
            return this.deleteRecords(module, LeadId);
        }

        public List<Leads> getRelatedRecords(long id, string parentModule)
        {
            return this.getRelatedRecords<List<Leads>>(module, id, parentModule);
        }

        public List<Leads> getRelatedRecords(long id, string parentModule, Dictionary<string, string> parameters)
        {
            return this.getRelatedRecords<List<Leads>>(module, id, parentModule, parameters);
        }

        public Fields getFields()
        {
            return this.getFields(module);
        }

        public bool uploadFile(long LeadId, string filePath)
        {
            return this.uploadFile(module, LeadId, filePath);
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

        public bool uploadPhoto(long LeadId, string filePath)
        {
            return this.uploadPhoto(module, LeadId, filePath);
        }

        public bool downloadPhoto(long LeadId)
        {
            return this.downloadPhoto(module, LeadId, "");
        }

        public bool downloadPhoto(long LeadId, string filePath)
        {
            return this.downloadPhoto(module, LeadId, filePath);
        }

        public bool deletePhoto(long LeadId)
        {
            return this.deletePhoto(module, LeadId);
        }
    }
}
