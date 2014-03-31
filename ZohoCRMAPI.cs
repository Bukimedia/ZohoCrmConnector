using System;
using System.Net;
using System.IO;
using System.Web;
using System.Text;
using System.Net.Security;
using System.Xml;

public class ZohoCRMAPI
{
    public static string zohocrmurl = "https://crm.zoho.com/crm/private/xml/";
    public static void Main(string[] args)
    {
        string result = APIMethod("Leads", "getRecords", "1122040000000069003");//Change the id,method name, and module name here
        XmlDocument xDoc = new XmlDocument();
        xDoc.LoadXml(result);
        Console.Write(result);
    }
    public static String APIMethod(string modulename, string methodname, string recordId)
    {
        string uri = zohocrmurl + modulename + "/" + methodname + "?";
        /* Append your parameters here */
        string postContent = "scope=crmapi";
        postContent = postContent + "&authtoken=b447d78308ef09d3bb3da3849da90c71";//Give your authtoken
        if (methodname.Equals("insertRecords") || methodname.Equals("updateRecords"))
        {
           // postContent = postContent + "&xmlData=" + HttpUtility.UrlEncode("Your CompanyHannahSmithtesting@testing.com");
        }
        if (methodname.Equals("updateRecords") || methodname.Equals("deleteRecords") || methodname.Equals("getRecordById"))
        {
            postContent = postContent + "&id=" + recordId;
        }
        string result = AccessCRM(uri, postContent);
        return result;
    }
    public static string AccessCRM(string url, string postcontent)
    {
        WebRequest request = WebRequest.Create(url);
        request.Method = "POST";
        byte[] byteArray = Encoding.UTF8.GetBytes(postcontent);
        request.ContentType = "application/x-www-form-urlencoded";
        request.ContentLength = byteArray.Length;
        Stream dataStream = request.GetRequestStream();
        dataStream.Write(byteArray, 0, byteArray.Length);
        dataStream.Close();
        WebResponse response = request.GetResponse();
        dataStream = response.GetResponseStream();
        StreamReader reader = new StreamReader(dataStream);
        string responseFromServer = reader.ReadToEnd();
        reader.Close();
        dataStream.Close();
        response.Close();
        return responseFromServer;
    }
}
