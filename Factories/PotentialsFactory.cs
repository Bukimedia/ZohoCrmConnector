using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZohoCrmConnector.Entities;

namespace ZohoCrmConnector.Factories
{
    public class PotentialsFactory : RestSharpFactory
    {
        public PotentialsFactory(string userToken)
            : base(userToken)
        {
            module = "Potentials";
        }

        public List<Potentials> getMyRecords()
        {
            return this.getMyRecords<List<Potentials>>(module);
        }

        public List<Potentials> getMyRecords(Dictionary<string, string> parameters)
        {
            return this.getMyRecords<List<Potentials>>(module, parameters);
        }

        public List<Potentials> getRecords()
        {
            return this.getRecords<List<Potentials>>(module);
        }

        public List<Potentials> getRecords(Dictionary<string, string> parameters)
        {
            return this.getRecords<List<Potentials>>(module, parameters);
        }

        public Potentials getRecordById(long PotentialId)
        {
            return this.getRecordById<List<Potentials>>(module, PotentialId)[0];
        }

        public Potentials getRecordById(long PotentialId, Dictionary<string, string> parameters)
        {
            return this.getRecordById<Potentials>(module, PotentialId, parameters);
        }

        public List<Potentials> getCVRecords(String cvName)
        {
            return this.getCVRecords<List<Potentials>>(module, cvName);
        }

        public List<Potentials> getCVRecords(String cvName, Dictionary<string, string> parameters)
        {
            return this.getCVRecords<List<Potentials>>(module, cvName, parameters);
        }

        public bool insertRecords(List<Potentials> listPotentials)
        {
            return this.insertRecords(module, listPotentials);
        }

        public bool insertRecords(List<Potentials> listPotentials, Dictionary<string, string> parameters)
        {
            return this.insertRecords(module, listPotentials, parameters);
        }

        public bool updateRecords(long PotentialId, Potentials Potential)
        {
            List<Potentials> listPotentials = new List<Potentials>();
            listPotentials.Add(Potential);
            return this.updateRecords(module, PotentialId, listPotentials);
        }

        public bool updateRecords(long PotentialId, Potentials Potential, Dictionary<string, string> parameters)
        {
            List<Potentials> listPotentials = new List<Potentials>();
            listPotentials.Add(Potential);
            return this.updateRecords(module, PotentialId, listPotentials, parameters);
        }

        public List<Potentials> getSearchRecords(string searchCondition)
        {
            return this.getSearchRecords<List<Potentials>>(module, searchCondition);
        }

        public List<Potentials> getSearchRecords(string searchCondition, Dictionary<string, string> parameters)
        {
            return this.getSearchRecords<List<Potentials>>(module, searchCondition, parameters);
        }

        public List<Potentials> getSearchRecordsByPDC(string searchColumn, string searchValue)
        {
            return this.getSearchRecordsByPDC<List<Potentials>>(module, searchColumn, searchValue);
        }

        public List<Potentials> getSearchRecordsByPDC(string searchColumn, string searchValue, Dictionary<string, string> parameters)
        {
            return this.getSearchRecordsByPDC<List<Potentials>>(module, searchColumn, searchValue, parameters);
        }

        public bool deleteRecords(long PotentialId)
        {
            return this.deleteRecords(module, PotentialId);
        }

        public List<Potentials> getRelatedRecords(long id, string parentModule)
        {
            return this.getRelatedRecords<List<Potentials>>(module, id, parentModule);
        }

        public List<Potentials> getRelatedRecords(long id, string parentModule, Dictionary<string, string> parameters)
        {
            return this.getRelatedRecords<List<Potentials>>(module, id, parentModule, parameters);
        }

        public Fields getFields()
        {
            return this.getFields(module);
        }

        public bool uploadFile(long PotentialId, string filePath)
        {
            return this.uploadFile(module, PotentialId, filePath);
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
