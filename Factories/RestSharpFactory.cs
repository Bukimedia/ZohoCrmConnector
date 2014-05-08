using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using ZohoCrmConnector.Entities;

namespace ZohoCrmConnector.Factories
{
    public abstract class RestSharpFactory
    {
        private static string BASEURL = "https://crm.zoho.com/crm/private/xml/";
        protected string userToken { get; set; }
        protected string module { get; set; }
        protected string method { get; set; }
        protected RestClient client;

        public RestSharpFactory(string userToken)
        {
            this.userToken = userToken;
            client = new RestClient();
            client.BaseUrl = BASEURL;
        }

        private RestRequest buildRequest(string module, string method)
        {
            this.module = module;
            this.method = method;
            RestRequest request = new RestRequest(Method.POST);
            request.Resource = "{module}/{method}";
            request.AddParameter("module", module, ParameterType.UrlSegment);
            request.AddParameter("method", method, ParameterType.UrlSegment);
            request.AddParameter("authtoken", userToken);
            request.AddParameter("scope", "crmapi");
            return request;
        }

        private IRestResponse<T> ExecuteQuery<T>(RestRequest request) where T : new()
        {
            var response = client.Execute<T>(request);

            if (response.Content.Contains("<error><code>") || response.ResponseStatus == ResponseStatus.Error)
            {
                ModifyForException(response.Content);
            }
            var newResponse = new RestResponse();
            newResponse.Content = "<result>" + cleanXML(response.Content) + "</result>";
            response.Data = new XmlDeserializer().Deserialize<T>(newResponse);

            return response;
        }

        private bool ExecuteInsert(RestRequest request)
        {
            var response = client.Execute(request);

            if (response.Content.Contains("<error><code>") || response.ResponseStatus == ResponseStatus.Error)
            {
                ModifyForException(response.Content);
            }

            return readXML(response.Content);
        }

        protected T getMyRecords<T>(string module) where T : new()
        {
            RestRequest request = buildRequest(module, "getMyRecords");
            return ExecuteQuery<T>(request).Data;
        }

        protected T getMyRecords<T>(string module, Dictionary<string, string> parameters) where T : new()
        {
            RestRequest request = buildRequest(module, "getMyRecords");
            foreach (KeyValuePair<string, string> pair in parameters)
            {
                request.AddParameter(pair.Key, pair.Value);
            }
            return ExecuteQuery<T>(request).Data;
        }

        protected T getRecords<T>(string module) where T : new()
        {
            RestRequest request = buildRequest(module, "getRecords");
            return ExecuteQuery<T>(request).Data;
        }

        protected T getRecords<T>(string module, Dictionary<string, string> parameters) where T : new()
        {
            RestRequest request = buildRequest(module, "getRecords");
            foreach (KeyValuePair<string, string> pair in parameters)
            {
                request.AddParameter(pair.Key, pair.Value);
            }
            return ExecuteQuery<T>(request).Data;
        }

        protected T getRecordById<T>(string module, long id) where T : new()
        {
            RestRequest request = buildRequest(module, "getRecordById");
            request.AddParameter("id", id);
            return ExecuteQuery<T>(request).Data;
        }

        protected T getRecordById<T>(string module, long id, Dictionary<string, string> parameters) where T : new()
        {
            RestRequest request = buildRequest(module, "getRecordById");
            request.AddParameter("id", id);
            foreach (KeyValuePair<string, string> pair in parameters)
            {
                request.AddParameter(pair.Key, pair.Value);
            }
            return ExecuteQuery<T>(request).Data;
        }

        protected T getCVRecords<T>(string module, String cvName) where T : new()
        {
            RestRequest request = buildRequest(module, "getCVRecords");
            request.AddParameter("cvName", cvName);
            return ExecuteQuery<T>(request).Data;
        }

        protected T getCVRecords<T>(string module, String cvName, Dictionary<string, string> parameters) where T : new()
        {
            RestRequest request = buildRequest(module, "getCVRecords");
            request.AddParameter("cvName", cvName);
            foreach (KeyValuePair<string, string> pair in parameters)
            {
                request.AddParameter(pair.Key, pair.Value);
            }
            return ExecuteQuery<T>(request).Data;
        }

        protected bool insertRecords<T>(string module, List<T> listEntity)
        {
            RestRequest request = buildRequest(module, "insertRecords");
            request.AddParameter("xmlData", buildXML<T>(listEntity));
            return ExecuteInsert(request);
        }

        protected bool insertRecords<T>(string module, List<T> listEntity, Dictionary<string, string> parameters)
        {
            RestRequest request = buildRequest(module, "insertRecords");
            foreach (KeyValuePair<string, string> pair in parameters)
            {
                request.AddParameter(pair.Key, pair.Value);
            }
            request.AddParameter("xmlData", buildXML<T>(listEntity));
            return ExecuteInsert(request);
        }

        protected bool updateRecords<T>(string module, long id, List<T> listEntity)
        {
            RestRequest request = buildRequest(module, "updateRecords");
            request.AddParameter("id", id);
            request.AddParameter("xmlData", buildXML<T>(listEntity));
            return ExecuteInsert(request);
        }

        protected bool updateRecords<T>(string module, long id, List<T> listEntity, Dictionary<string, string> parameters)
        {
            RestRequest request = buildRequest(module, "updateRecords");
            request.AddParameter("id", id);
            foreach (KeyValuePair<string, string> pair in parameters)
            {
                request.AddParameter(pair.Key, pair.Value);
            }
            request.AddParameter("xmlData", buildXML<T>(listEntity));
            return ExecuteInsert(request);
        }

        protected T getSearchRecords<T>(string module, string searchCondition)  where T : new()
        {
            RestRequest request = buildRequest(module, "getSearchRecords");
            request.AddParameter("selectColumns", "All");
            request.AddParameter("searchCondition", "("+searchCondition+")");
            return ExecuteQuery<T>(request).Data;
        }

        protected T getSearchRecords<T>(string module, string searchCondition, Dictionary<string, string> parameters) where T : new()
        {
            RestRequest request = buildRequest(module, "getSearchRecords");
            foreach (KeyValuePair<string, string> pair in parameters)
            {
                request.AddParameter(pair.Key, pair.Value);
            }
            request.AddParameter("selectColumns", "All");
            request.AddParameter("searchCondition", "(" + searchCondition + ")");
            return ExecuteQuery<T>(request).Data;
        }

        protected T getSearchRecordsByPDC<T>(string module, string searchColumn, string searchValue) where T : new()
        {
            RestRequest request = buildRequest(module, "getSearchRecordsByPDC");
            request.AddParameter("selectColumns", "All");
            request.AddParameter("searchColumn", searchColumn);
            request.AddParameter("searchValue", searchValue);
            return ExecuteQuery<T>(request).Data;
        }

        protected T getSearchRecordsByPDC<T>(string module, string searchColumn, string searchValue, Dictionary<string, string> parameters) where T : new()
        {
            RestRequest request = buildRequest(module, "getSearchRecordsByPDC");
            foreach (KeyValuePair<string, string> pair in parameters)
            {
                request.AddParameter(pair.Key, pair.Value);
            }
            request.AddParameter("selectColumns", "All");
            request.AddParameter("searchColumn", searchColumn);
            request.AddParameter("searchValue", searchValue);
            return ExecuteQuery<T>(request).Data;
        }

        protected T getRelatedRecords<T>(string module, long id, string parentModule) where T : new()
        {
            RestRequest request = buildRequest(module, "getRelatedRecords");
            request.AddParameter("id", id);
            request.AddParameter("parentModule", parentModule);
            return ExecuteQuery<T>(request).Data;
        }

        protected Fields getFields(String module)
        {
            RestRequest request = buildRequest(module, "getFields");
            var response = client.Execute(request);

            if (response.Content.Contains("<error><code>") || response.ResponseStatus == ResponseStatus.Error)
            {
                ModifyForException(response.Content);
            }

            return extractFields(response.Content);
        }

        protected T getRelatedRecords<T>(string module, long id, string parentModule, Dictionary<string, string> parameters) where T : new()
        {
            RestRequest request = buildRequest(module, "getRelatedRecords");
            foreach (KeyValuePair<string, string> pair in parameters)
            {
                request.AddParameter(pair.Key, pair.Value);
            }
            request.AddParameter("id", id);
            request.AddParameter("parentModule", parentModule);
            return ExecuteQuery<T>(request).Data;
        }

        protected bool deleteRecords(string module, long id)
        {
            RestRequest request = buildRequest(module, "deleteRecords");
            request.AddParameter("id", id);
            return ExecuteInsert(request);
        }

        protected bool uploadFile(string module, long id, string filePath)
        {
            RestRequest request = buildRequest(module, "uploadFile");
            request.AddParameter("id", id);
            request.AddFile("content", filePath);

            //FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            //BinaryReader reader = new BinaryReader(stream);
            //request.AddParameter("content",reader.ReadBytes(Convert.ToInt32(stream.Length)));

            return ExecuteInsert(request);
        }

        protected bool downloadFile(string module, long id, string filePath)
        {
            RestRequest request = buildRequest(module, "downloadFile");
            request.AddParameter("id", id);
            var response = client.Execute(request);
            string fileName = response.Headers[9].Value.ToString().Substring(28, response.Headers[9].Value.ToString().Length - 28);
            // data a ser guardada
            FileStream stream = new FileStream(filePath + fileName, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(stream);
            // números son guardados en formáto UTF-8 format (4 bytes)
            writer.Write(response.RawBytes);

            writer.Close();
            stream.Close();
            return true;
        }

        protected bool deleteFile(string module, long id)
        {
            RestRequest request = buildRequest(module, "deleteFile");
            request.AddParameter("id", id);
            return ExecuteInsert(request);
        }

        protected bool uploadPhoto(string module, long id, string filePath)
        {
            RestRequest request = buildRequest(module, "uploadPhoto");
            //request.Method = Method.POST;
            request.AddParameter("id", id);
            request.AddFile("content", filePath);
            //FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            //BinaryReader reader = new BinaryReader(stream);
            //byte[] chunk = reader.ReadBytes(Convert.ToInt32(stream.Length));
            //request.AddParameter("content", );
            
            return ExecuteInsert(request);
        }

        protected bool downloadPhoto(string module, long id, string filePath)
        {
            RestRequest request = buildRequest(module, "downloadPhoto");
            request.AddParameter("id", id);
            var response = client.Execute(request);
            string fileName = response.Headers[9].Value.ToString().Substring(28, response.Headers[9].Value.ToString().Length - 28) + ".png";
            // data a ser guardada
            FileStream stream = new FileStream(filePath + fileName, FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter writer = new BinaryWriter(stream);
            // números son guardados en formáto UTF-8 format (4 bytes)
            writer.Write(response.RawBytes);

            writer.Close();
            stream.Close();
            return true;
        }

        protected bool deletePhoto(string module, long id)
        {
            RestRequest request = buildRequest(module, "deletePhoto");
            request.AddParameter("id", id);
            return ExecuteInsert(request);
        }

        protected T getUsers<T>(string type) where T : new()
        {
            RestRequest request = buildRequest("Users", "getUsers");
            request.AddParameter("type", type);
            var response = client.Execute<T>(request);

            var newResponse = new RestResponse();
            newResponse.Content = convertXML(response.Content);
            response.Data = new XmlDeserializer().Deserialize<T>(newResponse);

            return response.Data;
        }

        private void ModifyForException(string XMLtoEdit)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.LoadXml(XMLtoEdit);
            xDoc.LoadXml(xDoc.ChildNodes[1].InnerXml);
            ThrowException(xDoc);
        }

        private void ThrowException(XmlDocument xDoc)
        {
            var Exception = new ApplicationException(
                       xDoc.FirstChild.Name + ": " +
                       xDoc.FirstChild.ChildNodes[0].Name + " - " +
                       xDoc.FirstChild.ChildNodes[0].InnerText + ", " +
                       xDoc.FirstChild.ChildNodes[1].InnerText);
            throw Exception;
        }

        private Fields extractFields(String xmlContent)
        {
            Fields fields = new Fields();

            XmlDocument xDoc = new XmlDocument();
            xDoc.LoadXml(xmlContent);

            XmlNodeList elemento = xDoc.GetElementsByTagName(module);

            for (int i = 0; i < elemento.Item(0).ChildNodes.Count; i++)
            {
                fields.listSections.Add(new Fields.Section());
                fields.listSections.ElementAt(i).name = elemento.Item(0).ChildNodes.Item(i).Attributes.Item(0).Value;
                fields.listSections.ElementAt(i).dv = elemento.Item(0).ChildNodes.Item(i).Attributes.Item(1).Value;
                if (elemento.Item(0).ChildNodes.Item(i).ChildNodes.Count > 0)
                {
                    for (int j = 0; j < elemento.Item(0).ChildNodes.Item(i).ChildNodes.Count; j++)
                    {
                        fields.listSections.ElementAt(i).listFields.Add(new Fields.Section.Field());
                        fields.listSections.ElementAt(i).listFields.ElementAt(j).req = elemento.Item(0).ChildNodes.Item(i).ChildNodes.Item(j).Attributes.Item(0).Value;
                        fields.listSections.ElementAt(i).listFields.ElementAt(j).type = elemento.Item(0).ChildNodes.Item(i).ChildNodes.Item(j).Attributes.Item(1).Value;
                        if (fields.listSections.ElementAt(i).listFields.ElementAt(j).type.Equals("Pick List"))
                        {
                            for (int k = 0; k < elemento.Item(0).ChildNodes.Item(i).ChildNodes.Item(j).ChildNodes.Count; k++)
                            {
                                fields.listSections.ElementAt(i).listFields.ElementAt(j).listValues.Add(new Fields.Section.Field.Value());
                                fields.listSections.ElementAt(i).listFields.ElementAt(j).listValues.ElementAt(k).val =
                                    elemento.Item(0).ChildNodes.Item(i).ChildNodes.Item(j).ChildNodes.Item(k).InnerText;
                            }
                        }
                        fields.listSections.ElementAt(i).listFields.ElementAt(j).isreadonly = elemento.Item(0).ChildNodes.Item(i).ChildNodes.Item(j).Attributes.Item(2).Value;
                        fields.listSections.ElementAt(i).listFields.ElementAt(j).maxlength = elemento.Item(0).ChildNodes.Item(i).ChildNodes.Item(j).Attributes.Item(3).Value;
                        fields.listSections.ElementAt(i).listFields.ElementAt(j).label = elemento.Item(0).ChildNodes.Item(i).ChildNodes.Item(j).Attributes.Item(4).Value;
                        fields.listSections.ElementAt(i).listFields.ElementAt(j).dv = elemento.Item(0).ChildNodes.Item(i).ChildNodes.Item(j).Attributes.Item(5).Value;
                        fields.listSections.ElementAt(i).listFields.ElementAt(j).customfield = elemento.Item(0).ChildNodes.Item(i).ChildNodes.Item(j).Attributes.Item(6).Value;
                    }
                }
            }

            return fields;
        }


        private bool readXML(string xmlContent)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.LoadXml(xmlContent);

            bool success = xDoc.GetElementsByTagName("message").Item(0).InnerText.Equals("Record(s) added successfully")
                || xDoc.GetElementsByTagName("message").Item(0).InnerText.Equals("Record(s) updated successfully")
                || xDoc.GetElementsByTagName("code").Item(0).InnerText.Equals("5000")
                || xDoc.GetElementsByTagName("code").Item(0).InnerText.Equals("4800");
            
            if (!success)
            {
                xDoc.LoadXml(xDoc.ChildNodes[0].InnerXml);
                ThrowException(xDoc);
            }

            return success;
        }

        private String buildXML<T>(List<T> list)
        {
            String xmlDoc = "<" + module + ">";
            for (int i = 0; i < list.Count(); i++)
            {
                xmlDoc += "<row no=\"" + (i + 1) + "\">";
                var type = list[i].GetType();
                var properties = type.GetProperties();

                for (int j = 0; j < properties.Count(); j++)
                {
                    if (properties[j].GetValue(list[i],null) != null)
                    {
                        xmlDoc += "<FL val=\"" + properties[j].Name.Replace("_", " ") + "\">" + properties[j].GetValue(list[i],null) + "</FL>";
                    }
                }
                xmlDoc += "</row>";
            }
            xmlDoc += "</" + module + ">";
            return xmlDoc;
        }

        private string cleanXML(string xmlContent)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.LoadXml(xmlContent);
            XmlNodeList row = xDoc.GetElementsByTagName("row");
            if (row.Count == 0)
            {
                xDoc.LoadXml(xDoc.GetElementsByTagName("response").Item(0).InnerXml);
                ThrowException(xDoc);
            }

            string xmldoc = "";

            for (int i = 0; i < row.Count; i++)
            {
                XmlNodeList elemento = ((XmlElement)row[i]).ChildNodes;
                xmldoc += "<" + module + ">";
                foreach (XmlElement subnodo in elemento)
                {
                    string atributo = subnodo.GetAttribute("val").Replace(' ', '_');
                    String fff = subnodo.LastChild.ToString();

                    if (subnodo.LastChild.ToString().Equals("System.Xml.XmlElement"))
                    {
                        xmldoc += "<" + atributo + ">";
                        for (int j = 0; j < subnodo.ChildNodes.Count; j++)
                        {
                            XmlNodeList subelemento = ((XmlElement)subnodo.ChildNodes[j]).GetElementsByTagName("FL");
                            xmldoc += "<" + subnodo.FirstChild.Name + ">";
                            foreach (XmlElement sub_nodo in subelemento)
                            {
                                string atributo2 = sub_nodo.GetAttribute("val").Replace(' ', '_');
                                xmldoc += "<" + atributo2 + ">" + sub_nodo.InnerText + "</" + atributo2 + ">";
                            }
                            xmldoc += "</" + subnodo.FirstChild.Name + ">";
                        }
                        xmldoc += "</" + atributo + ">";
                    }
                    else
                    {
                        xmldoc += "<" + atributo + ">" + subnodo.InnerText + "</" + atributo + ">";
                    }
                }
                xmldoc += "</" + module + ">";
            }
            return xmldoc;
        }

        private string convertXML(string xmlContent)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.LoadXml(xmlContent);
            XmlNodeList user = xDoc.GetElementsByTagName("user");

            string xmldoc = "";

            xmldoc += "<response>";
            foreach (XmlElement subnodo in user)
            {
                xmldoc += "<" + module + ">";
                Users xxx = new Users();
                var type = xxx.GetType();

                var properties = type.GetProperties();

                for (int i = 0; i < properties.Count()-1; i++)
                {
                    xmldoc += "<" + properties[i].Name + ">" + subnodo.GetAttribute(properties[i].Name) + "</" + properties[i].Name + ">";
                }
                xmldoc += "<" + properties[properties.Count() - 1].Name + ">" + subnodo.InnerText + "</" + properties[properties.Count() - 1].Name + ">";
                xmldoc += "</" + module + ">";
            }
            xmldoc += "</response>";
            
            return xmldoc;
        }
    }
}
