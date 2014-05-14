using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZohoCrmConnector.Entities;

namespace ZohoCrmConnector.Factories
{
    public class EventsFactory : RestSharpFactory
    {
        public EventsFactory(string userToken)
            : base(userToken)
        {
            module = "Events";
        }

        public List<Events> getMyRecords()
        {
            return this.getMyRecords<List<Events>>(module);
        }

        public List<Events> getMyRecords(Dictionary<string, string> parameters)
        {
            return this.getMyRecords<List<Events>>(module, parameters);
        }

        public List<Events> getRecords()
        {
            return this.getRecords<List<Events>>(module);
        }

        public List<Events> getRecords(Dictionary<string, string> parameters)
        {
            return this.getRecords<List<Events>>(module, parameters);
        }

        public Events getRecordById(long EventId)
        {
            return this.getRecordById<List<Events>>(module, EventId)[0];
        }

        public Events getRecordById(long EventId, Dictionary<string, string> parameters)
        {
            return this.getRecordById<Events>(module, EventId, parameters);
        }

        public List<Events> getCVRecords(String cvName)
        {
            return this.getCVRecords<List<Events>>(module, cvName);
        }

        public List<Events> getCVRecords(String cvName, Dictionary<string, string> parameters)
        {
            return this.getCVRecords<List<Events>>(module, cvName, parameters);
        }

        public bool insertRecords(List<Events> listEvents)
        {
            return this.insertRecords(module, listEvents);
        }

        public bool insertRecords(List<Events> listEvents, Dictionary<string, string> parameters)
        {
            return this.insertRecords(module, listEvents, parameters);
        }

        public bool updateRecords(long EventId, Events Event)
        {
            List<Events> listEvents = new List<Events>();
            listEvents.Add(Event);
            return this.updateRecords(module, EventId, listEvents);
        }

        public bool updateRecords(long EventId, Events Event, Dictionary<string, string> parameters)
        {
            List<Events> listEvents = new List<Events>();
            listEvents.Add(Event);
            return this.updateRecords(module, EventId, listEvents, parameters);
        }

        public List<Events> getSearchRecords(string searchCondition)
        {
            return this.getSearchRecords<List<Events>>(module, searchCondition);
        }

        public List<Events> getSearchRecords(string searchCondition, Dictionary<string, string> parameters)
        {
            return this.getSearchRecords<List<Events>>(module, searchCondition, parameters);
        }

        public List<Events> getSearchRecordsByPDC(string searchColumn, string searchValue)
        {
            return this.getSearchRecordsByPDC<List<Events>>(module, searchColumn, searchValue);
        }

        public List<Events> getSearchRecordsByPDC(string searchColumn, string searchValue, Dictionary<string, string> parameters)
        {
            return this.getSearchRecordsByPDC<List<Events>>(module, searchColumn, searchValue, parameters);
        }

        public bool deleteRecords(long EventId)
        {
            return this.deleteRecords(module, EventId);
        }

        public List<Events> getRelatedRecords(long id, string parentModule)
        {
            return this.getRelatedRecords<List<Events>>(module, id, parentModule);
        }

        public List<Events> getRelatedRecords(long id, string parentModule, Dictionary<string, string> parameters)
        {
            return this.getRelatedRecords<List<Events>>(module, id, parentModule, parameters);
        }

        public Fields getFields()
        {
            return this.getFields(module);
        }

        public bool uploadFile(long EventId, string filePath)
        {
            return this.uploadFile(module, EventId, filePath);
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
