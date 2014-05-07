using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZohoCrmConnector.Entities;

namespace ZohoCrmConnector.Factories
{
    public class SolutionsFactory : RestSharpFactory
    {
        public SolutionsFactory(string userToken)
            : base(userToken)
        {
            module = "Solutions";
        }

        public List<Solutions> getMyRecords()
        {
            return this.getMyRecords<List<Solutions>>(module);
        }

        public List<Solutions> getMyRecords(Dictionary<string, string> parameters)
        {
            return this.getMyRecords<List<Solutions>>(module, parameters);
        }

        public List<Solutions> getRecords()
        {
            return this.getRecords<List<Solutions>>(module);
        }

        public List<Solutions> getRecords(Dictionary<string, string> parameters)
        {
            return this.getRecords<List<Solutions>>(module, parameters);
        }

        public Solutions getRecordById(long SolutionId)
        {
            return this.getRecordById<List<Solutions>>(module, SolutionId)[0];
        }

        public Solutions getRecordById(long SolutionId, Dictionary<string, string> parameters)
        {
            return this.getRecordById<Solutions>(module, SolutionId, parameters);
        }

        public List<Solutions> getCVRecords(String cvName)
        {
            return this.getCVRecords<List<Solutions>>(module, cvName);
        }

        public List<Solutions> getCVRecords(String cvName, Dictionary<string, string> parameters)
        {
            return this.getCVRecords<List<Solutions>>(module, cvName, parameters);
        }

        public bool insertRecords(List<Solutions> listSolutions)
        {
            return this.insertRecords(module, listSolutions);
        }

        public bool insertRecords(List<Solutions> listSolutions, Dictionary<string, string> parameters)
        {
            return this.insertRecords(module, listSolutions, parameters);
        }

        public bool updateRecords(long SolutionId, List<Solutions> listSolutions)
        {
            return this.updateRecords(module, SolutionId, listSolutions);
        }

        public bool updateRecords(long SolutionId, List<Solutions> listSolutions, Dictionary<string, string> parameters)
        {
            return this.updateRecords(module, SolutionId, listSolutions, parameters);
        }

        public List<Solutions> getSearchRecords(string searchCondition)
        {
            return this.getSearchRecords<List<Solutions>>(module, searchCondition);
        }

        public List<Solutions> getSearchRecords(string searchCondition, Dictionary<string, string> parameters)
        {
            return this.getSearchRecords<List<Solutions>>(module, searchCondition, parameters);
        }

        public List<Solutions> getSearchRecordsByPDC(string searchColumn, string searchValue)
        {
            return this.getSearchRecordsByPDC<List<Solutions>>(module, searchColumn, searchValue);
        }

        public List<Solutions> getSearchRecordsByPDC(string searchColumn, string searchValue, Dictionary<string, string> parameters)
        {
            return this.getSearchRecordsByPDC<List<Solutions>>(module, searchColumn, searchValue, parameters);
        }

        public bool deleteRecords(long SolutionId)
        {
            return this.deleteRecords(module, SolutionId);
        }

        public List<Solutions> getRelatedRecords(long id, string parentModule)
        {
            return this.getRelatedRecords<List<Solutions>>(module, id, parentModule);
        }

        public List<Solutions> getRelatedRecords(long id, string parentModule, Dictionary<string, string> parameters)
        {
            return this.getRelatedRecords<List<Solutions>>(module, id, parentModule, parameters);
        }

        public Fields getFields()
        {
            return this.getFields(module);
        }

        public bool uploadFile(long SolutionId, string filePath)
        {
            return this.uploadFile(module, SolutionId, filePath);
        }

        public bool downloadFile(long AttachmentId)
        {
            return this.downloadFile(module, AttachmentId);
        }

        public bool deleteFile(long AttachmentId)
        {
            return this.deleteFile(module, AttachmentId);
        }

        public bool uploadPhoto(long SolutionId, string filePath)
        {
            return this.uploadPhoto(module, SolutionId, filePath);
        }

        public bool downloadPhoto(long SolutionId)
        {
            return this.downloadPhoto(module, SolutionId);
        }

        public bool deletePhoto(long SolutionId)
        {
            return this.deletePhoto(module, SolutionId);
        }
    }
}
