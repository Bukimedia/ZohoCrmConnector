using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZohoCrmConnector.Entities;

namespace ZohoCrmConnector.Factories
{
    public class CampaignsFactory : RestSharpFactory
    {
        public CampaignsFactory(string userToken)
            : base(userToken)
        {
            module="Campaigns";
        }

        public List<Campaigns> getMyRecords()
        {
            return this.getMyRecords<List<Campaigns>>(module);
        }

        public List<Campaigns> getMyRecords(Dictionary<string, string> parameters)
        {
            return this.getMyRecords<List<Campaigns>>(module, parameters);
        }

        public List<Campaigns> getRecords()
        {
            return this.getRecords<List<Campaigns>>(module);
        }

        public List<Campaigns> getRecords(Dictionary<string, string> parameters)
        {
            return this.getRecords<List<Campaigns>>(module, parameters);
        }

        public Campaigns getRecordById(long CampaignId)
        {
            return this.getRecordById<List<Campaigns>>(module, CampaignId)[0];
        }

        public Campaigns getRecordById(long CampaignId, Dictionary<string, string> parameters)
        {
            return this.getRecordById<Campaigns>(module, CampaignId, parameters);
        }

        public List<Campaigns> getCVRecords(String cvName)
        {
            return this.getCVRecords<List<Campaigns>>(module, cvName);
        }

        public List<Campaigns> getCVRecords(String cvName, Dictionary<string, string> parameters)
        {
            return this.getCVRecords<List<Campaigns>>(module, cvName, parameters);
        }

        public bool insertRecords(List<Campaigns> listCampaigns)
        {
            return this.insertRecords(module, listCampaigns);
        }

        public bool insertRecords(List<Campaigns> listCampaigns, Dictionary<string, string> parameters)
        {
            return this.insertRecords(module, listCampaigns, parameters);
        }

        public bool updateRecords(long CampaignId, List<Campaigns> listCampaigns)
        {
            return this.updateRecords(module, CampaignId, listCampaigns);
        }

        public bool updateRecords(long CampaignId, List<Campaigns> listCampaigns, Dictionary<string, string> parameters)
        {
            return this.updateRecords(module, CampaignId, listCampaigns, parameters);
        }

        public List<Campaigns> getSearchRecords(string searchCondition)
        {
            return this.getSearchRecords<List<Campaigns>>(module, searchCondition);
        }

        public List<Campaigns> getSearchRecords(string searchCondition, Dictionary<string, string> parameters)
        {
            return this.getSearchRecords<List<Campaigns>>(module, searchCondition, parameters);
        }

        public List<Campaigns> getSearchRecordsByPDC(string searchColumn, string searchValue)
        {
            return this.getSearchRecordsByPDC<List<Campaigns>>(module, searchColumn, searchValue);
        }

        public List<Campaigns> getSearchRecordsByPDC(string searchColumn, string searchValue, Dictionary<string, string> parameters)
        {
            return this.getSearchRecordsByPDC<List<Campaigns>>(module, searchColumn, searchValue, parameters);
        }

        public bool deleteRecords(long CampaignId)
        {
            return this.deleteRecords(module, CampaignId);
        }

        public List<Campaigns> getRelatedRecords(long id, string parentModule)
        {
            return this.getRelatedRecords<List<Campaigns>>(module, id, parentModule);
        }

        public List<Campaigns> getRelatedRecords(long id, string parentModule, Dictionary<string, string> parameters)
        {
            return this.getRelatedRecords<List<Campaigns>>(module, id, parentModule, parameters);
        }

        public Fields getFields()
        {
            return this.getFields(module);
        }

        public bool uploadFile(long CampaignId, string filePath)
        {
            return this.uploadFile(module, CampaignId, filePath);
        }

        public bool downloadFile(long AttachmentId)
        {
            return this.downloadFile(module, AttachmentId);
        }

        public bool deleteFile(long AttachmentId)
        {
            return this.deleteFile(module, AttachmentId);
        }

        public bool uploadPhoto(long CampaignId, string filePath)
        {
            return this.uploadPhoto(module, CampaignId, filePath);
        }

        public bool downloadPhoto(long CampaignId)
        {
            return this.downloadPhoto(module, CampaignId);
        }

        public bool deletePhoto(long CampaignId)
        {
            return this.deletePhoto(module, CampaignId);
        }
    }
}
