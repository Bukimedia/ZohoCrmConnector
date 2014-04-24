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

        }

        public List<Leads> getMyRecords()
        {
            return this.getMyRecords<List<Leads>>("Leads");
        }

        public List<Leads> getMyRecords(Dictionary<string, string> parameters)
        {
            return this.getMyRecords<List<Leads>>("Leads", parameters);
        }

        public List<Leads> getRecords()
        {
            return this.getRecords<List<Leads>>("Leads");
        }

        public List<Leads> getRecords(Dictionary<string, string> parameters)
        {
            return this.getRecords<List<Leads>>("Leads", parameters);
        }

        public Leads getRecordById(long LeadId)
        {
            return this.getRecordById<List<Leads>>("Leads", LeadId)[0];
        }

        public Leads getRecordById(long LeadId, Dictionary<string, string> parameters)
        {
            return this.getRecordById<Leads>("Leads", LeadId, parameters);
        }

        public bool insertRecords(List<Leads> listLeads)
        {
            return this.insertRecords("Leads", listLeads);
        }

        public bool insertRecords(List<Leads> listLeads, Dictionary<string, string> parameters)
        {
            return this.insertRecords("Leads", listLeads, parameters);
        }

        public bool updateRecords(long LeadId, List<Leads> listLeads)
        {
            return this.updateRecords("Leads", LeadId, listLeads);
        }

        public bool updateRecords(long LeadId, List<Leads> listLeads, Dictionary<string, string> parameters)
        {
            return this.updateRecords("Leads", LeadId, listLeads, parameters);
        }

        public List<Leads> getSearchRecords(string searchCondition)
        {
            return this.getSearchRecords<List<Leads>>("Leads", searchCondition);
        }

        public List<Leads> getSearchRecords(string searchCondition, Dictionary<string, string> parameters)
        {
            return this.getSearchRecords<List<Leads>>("Leads", searchCondition, parameters);
        }

        public List<Leads> getSearchRecordsByPDC(string searchColumn, string searchValue)
        {
            return this.getSearchRecordsByPDC<List<Leads>>("Leads", searchColumn, searchValue);
        }

        public List<Leads> getSearchRecordsByPDC(string searchColumn, string searchValue, Dictionary<string, string> parameters)
        {
            return this.getSearchRecordsByPDC<List<Leads>>("Leads", searchColumn, searchValue, parameters);
        }

        public List<Leads> getRelatedRecords(long id, string parentModule)
        {
            return this.getRelatedRecords<List<Leads>>("Leads", id, parentModule);
        }

        public List<Leads> getRelatedRecords(long id, string parentModule, Dictionary<string, string> parameters)
        {
            return this.getRelatedRecords<List<Leads>>("Leads", id, parentModule, parameters);
        }

        public Entities.Fields getFields()
        {
            return this.getFields("Leads");
        }

        public bool deleteRecords(long LeadId)
        {
            return this.deleteRecords("Leads", LeadId);
        }

        public bool downloadFile(long AttachmentId)
        {
            return this.downloadFile("Leads", AttachmentId);
        }

        public bool deleteFile(long AttachmentId)
        {
            return this.deleteFile("Leads", AttachmentId);
        }

        public bool uploadPhoto(long LeadId, string filePath)
        {
            return this.uploadPhoto("Leads", LeadId, filePath);
        }

        public bool downloadPhoto(long LeadId)
        {
            return this.downloadPhoto("Leads", LeadId);
        }

        public bool deletePhoto(long LeadId)
        {
            return this.deletePhoto("Leads", LeadId);
        }
    }
}
