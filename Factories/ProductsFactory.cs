using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZohoCrmConnector.Entities;

namespace ZohoCrmConnector.Factories
{
    public class ProductsFactory : RestSharpFactory
    {
        public ProductsFactory(string userToken)
            : base(userToken)
        {
            module = "Products";
        }

        public List<Products> getMyRecords()
        {
            return this.getMyRecords<List<Products>>(module);
        }

        public List<Products> getMyRecords(Dictionary<string, string> parameters)
        {
            return this.getMyRecords<List<Products>>(module, parameters);
        }

        public List<Products> getRecords()
        {
            return this.getRecords<List<Products>>(module);
        }

        public List<Products> getRecords(Dictionary<string, string> parameters)
        {
            return this.getRecords<List<Products>>(module, parameters);
        }

        public Products getRecordById(long ProductId)
        {
            return this.getRecordById<List<Products>>(module, ProductId)[0];
        }

        public Products getRecordById(long ProductId, Dictionary<string, string> parameters)
        {
            return this.getRecordById<Products>(module, ProductId, parameters);
        }

        public List<Products> getCVRecords(String cvName)
        {
            return this.getCVRecords<List<Products>>(module, cvName);
        }

        public List<Products> getCVRecords(String cvName, Dictionary<string, string> parameters)
        {
            return this.getCVRecords<List<Products>>(module, cvName, parameters);
        }

        public bool insertRecords(List<Products> listProducts)
        {
            return this.insertRecords(module, listProducts);
        }

        public bool insertRecords(List<Products> listProducts, Dictionary<string, string> parameters)
        {
            return this.insertRecords(module, listProducts, parameters);
        }

        public bool updateRecords(long ProductId, Products Product)
        {
            List<Products> listProducts = new List<Products>();
            listProducts.Add(Product);
            return this.updateRecords(module, ProductId, listProducts);
        }

        public bool updateRecords(long ProductId, Products Product, Dictionary<string, string> parameters)
        {
            List<Products> listProducts = new List<Products>();
            listProducts.Add(Product);
            return this.updateRecords(module, ProductId, listProducts, parameters);
        }

        public List<Products> getSearchRecords(string searchCondition)
        {
            return this.getSearchRecords<List<Products>>(module, searchCondition);
        }

        public List<Products> getSearchRecords(string searchCondition, Dictionary<string, string> parameters)
        {
            return this.getSearchRecords<List<Products>>(module, searchCondition, parameters);
        }

        public List<Products> getSearchRecordsByPDC(string searchColumn, string searchValue)
        {
            return this.getSearchRecordsByPDC<List<Products>>(module, searchColumn, searchValue);
        }

        public List<Products> getSearchRecordsByPDC(string searchColumn, string searchValue, Dictionary<string, string> parameters)
        {
            return this.getSearchRecordsByPDC<List<Products>>(module, searchColumn, searchValue, parameters);
        }

        public bool deleteRecords(long ProductId)
        {
            return this.deleteRecords(module, ProductId);
        }

        public List<Products> getRelatedRecords(long id, string parentModule)
        {
            return this.getRelatedRecords<List<Products>>(module, id, parentModule);
        }

        public List<Products> getRelatedRecords(long id, string parentModule, Dictionary<string, string> parameters)
        {
            return this.getRelatedRecords<List<Products>>(module, id, parentModule, parameters);
        }

        public Fields getFields()
        {
            return this.getFields(module);
        }

        public bool uploadFile(long ProductId, string filePath)
        {
            return this.uploadFile(module, ProductId, filePath);
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
