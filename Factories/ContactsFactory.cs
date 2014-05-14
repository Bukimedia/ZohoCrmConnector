using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZohoCrmConnector.Entities;

namespace ZohoCrmConnector.Factories
{
    public class ContactsFactory : RestSharpFactory
    {
        public ContactsFactory(string userToken)
            : base(userToken)
        {
            module = "Contacts";
        }

        public List<Contacts> getMyRecords()
        {
            return this.getMyRecords<List<Contacts>>(module);
        }

        public List<Contacts> getMyRecords(Dictionary<string, string> parameters)
        {
            return this.getMyRecords<List<Contacts>>(module, parameters);
        }

        public List<Contacts> getRecords()
        {
            return this.getRecords<List<Contacts>>(module);
        }

        public List<Contacts> getRecords(Dictionary<string, string> parameters)
        {
            return this.getRecords<List<Contacts>>(module, parameters);
        }

        public Contacts getRecordById(long ContactId)
        {
            return this.getRecordById<List<Contacts>>(module, ContactId)[0];
        }

        public Contacts getRecordById(long ContactId, Dictionary<string, string> parameters)
        {
            return this.getRecordById<Contacts>(module, ContactId, parameters);
        }

        public List<Contacts> getCVRecords(String cvName)
        {
            return this.getCVRecords<List<Contacts>>(module, cvName);
        }

        public List<Contacts> getCVRecords(String cvName, Dictionary<string, string> parameters)
        {
            return this.getCVRecords<List<Contacts>>(module, cvName, parameters);
        }

        public bool insertRecords(List<Contacts> listContacts)
        {
            return this.insertRecords(module, listContacts);
        }

        public bool insertRecords(List<Contacts> listContacts, Dictionary<string, string> parameters)
        {
            return this.insertRecords(module, listContacts, parameters);
        }

        public bool updateRecords(long ContactId, Contacts Contact)
        {
            List<Contacts> listContacts = new List<Contacts>();
            listContacts.Add(Contact);
            return this.updateRecords(module, ContactId, listContacts);
        }

        public bool updateRecords(long ContactId, Contacts Contact, Dictionary<string, string> parameters)
        {
            List<Contacts> listContacts = new List<Contacts>();
            listContacts.Add(Contact);
            return this.updateRecords(module, ContactId, listContacts, parameters);
        }

        public List<Contacts> getSearchRecords(string searchCondition)
        {
            return this.getSearchRecords<List<Contacts>>(module, searchCondition);
        }

        public List<Contacts> getSearchRecords(string searchCondition, Dictionary<string, string> parameters)
        {
            return this.getSearchRecords<List<Contacts>>(module, searchCondition, parameters);
        }

        public List<Contacts> getSearchRecordsByPDC(string searchColumn, string searchValue)
        {
            return this.getSearchRecordsByPDC<List<Contacts>>(module, searchColumn, searchValue);
        }

        public List<Contacts> getSearchRecordsByPDC(string searchColumn, string searchValue, Dictionary<string, string> parameters)
        {
            return this.getSearchRecordsByPDC<List<Contacts>>(module, searchColumn, searchValue, parameters);
        }

        public bool deleteRecords(long ContactId)
        {
            return this.deleteRecords(module, ContactId);
        }

        public List<Contacts> getRelatedRecords(long id, string parentModule)
        {
            return this.getRelatedRecords<List<Contacts>>(module, id, parentModule);
        }

        public List<Contacts> getRelatedRecords(long id, string parentModule, Dictionary<string, string> parameters)
        {
            return this.getRelatedRecords<List<Contacts>>(module, id, parentModule, parameters);
        }

        public Fields getFields()
        {
            return this.getFields(module);
        }

        public bool uploadFile(long ContactId, string filePath)
        {
            return this.uploadFile(module, ContactId, filePath);
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

        public bool uploadPhoto(long ContactId, string filePath)
        {
            return this.uploadPhoto(module, ContactId, filePath);
        }

        public bool downloadPhoto(long ContactId)
        {
            return this.downloadPhoto(module, ContactId, "");
        }

        public bool downloadPhoto(long ContactId, string filePath)
        {
            return this.downloadPhoto(module, ContactId, filePath);
        }

        public bool deletePhoto(long ContactId)
        {
            return this.deletePhoto(module, ContactId);
        }
    }
}

