using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZohoCrmConnector.Entities;

namespace ZohoCrmConnector.Factories
{
    public class TasksFactory : RestSharpFactory
    {
        public TasksFactory(string userToken)
            : base(userToken)
        {
            module = "Tasks";
        }

        public List<Tasks> getMyRecords()
        {
            return this.getMyRecords<List<Tasks>>(module);
        }

        public List<Tasks> getMyRecords(Dictionary<string, string> parameters)
        {
            return this.getMyRecords<List<Tasks>>(module, parameters);
        }

        public List<Tasks> getRecords()
        {
            return this.getRecords<List<Tasks>>(module);
        }

        public List<Tasks> getRecords(Dictionary<string, string> parameters)
        {
            return this.getRecords<List<Tasks>>(module, parameters);
        }

        public Tasks getRecordById(long TaskId)
        {
            return this.getRecordById<List<Tasks>>(module, TaskId)[0];
        }

        public Tasks getRecordById(long TaskId, Dictionary<string, string> parameters)
        {
            return this.getRecordById<Tasks>(module, TaskId, parameters);
        }

        public List<Tasks> getCVRecords(String cvName)
        {
            return this.getCVRecords<List<Tasks>>(module, cvName);
        }

        public List<Tasks> getCVRecords(String cvName, Dictionary<string, string> parameters)
        {
            return this.getCVRecords<List<Tasks>>(module, cvName, parameters);
        }

        public bool insertRecords(List<Tasks> listTasks)
        {
            return this.insertRecords(module, listTasks);
        }

        public bool insertRecords(List<Tasks> listTasks, Dictionary<string, string> parameters)
        {
            return this.insertRecords(module, listTasks, parameters);
        }

        public bool updateRecords(long TaskId, List<Tasks> listTasks)
        {
            return this.updateRecords(module, TaskId, listTasks);
        }

        public bool updateRecords(long TaskId, List<Tasks> listTasks, Dictionary<string, string> parameters)
        {
            return this.updateRecords(module, TaskId, listTasks, parameters);
        }

        public List<Tasks> getSearchRecords(string searchCondition)
        {
            return this.getSearchRecords<List<Tasks>>(module, searchCondition);
        }

        public List<Tasks> getSearchRecords(string searchCondition, Dictionary<string, string> parameters)
        {
            return this.getSearchRecords<List<Tasks>>(module, searchCondition, parameters);
        }

        public List<Tasks> getSearchRecordsByPDC(string searchColumn, string searchValue)
        {
            return this.getSearchRecordsByPDC<List<Tasks>>(module, searchColumn, searchValue);
        }

        public List<Tasks> getSearchRecordsByPDC(string searchColumn, string searchValue, Dictionary<string, string> parameters)
        {
            return this.getSearchRecordsByPDC<List<Tasks>>(module, searchColumn, searchValue, parameters);
        }

        public bool deleteRecords(long TaskId)
        {
            return this.deleteRecords(module, TaskId);
        }

        public List<Tasks> getRelatedRecords(long id, string parentModule)
        {
            return this.getRelatedRecords<List<Tasks>>(module, id, parentModule);
        }

        public List<Tasks> getRelatedRecords(long id, string parentModule, Dictionary<string, string> parameters)
        {
            return this.getRelatedRecords<List<Tasks>>(module, id, parentModule, parameters);
        }

        public Fields getFields()
        {
            return this.getFields(module);
        }

        public bool uploadFile(long TaskId, string filePath)
        {
            return this.uploadFile(module, TaskId, filePath);
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
