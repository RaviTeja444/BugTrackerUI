using BugManagerUI.Interface;
using BugManagerUI.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BugManagerUI.Utility
{
    public class Utility:IUtility
    {
        //public static string token { get; set; }
        public string InsertProject(Project project)
        {
            WebRequest webRequest = WebRequest.Create("");
            //webRequest.
            return "";
        }

        public string Token()
        {
            string token = string.Empty;
            WebRequest web = WebRequest.Create(Startup.Tokenurl+"?username="+Startup.UserName+"&password="+Startup.Password);
            web.Method = "POST";
            web.ContentType = "text/plain";
            var response = (HttpWebResponse)web.GetResponse();
            if(response.StatusCode==HttpStatusCode.OK)
            {
                var reader = new StreamReader(response.GetResponseStream());
                var result = reader.ReadToEnd();
                token = result;
                //var jo = JObject.Parse(result);
                //token= jo["access_token"].ToString();
                return token;
            }
            return token;
        }

        public  void callAPI(string token)
        {
            WebRequest web = WebRequest.Create("http://localhost:5000/api/Values/5");
            web.ContentType = "text/plain";
            web.Method = "GET";
            web.Headers.Add("AUthorization", token);
            var response = (HttpWebResponse)web.GetResponse();
            if(response.StatusCode==HttpStatusCode.OK)
            {
                var reader = new StreamReader(response.GetResponseStream());
                var result = reader.ReadToEnd();
            }
       }

        public string createProject(string orgName,string projectsize,string projname,string token)
        {
            string result = String.Empty;
            WebRequest web = WebRequest.Create("http://localhost:5000/projectCreate"+"?orgname="+orgName+"&projsize="+projectsize+"&projname="+projname);

            web.ContentType = "text/plain";
            web.Method = "POST";
            web.Headers.Add("AUthorization", token);
            var response = (HttpWebResponse)web.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var reader = new StreamReader(response.GetResponseStream());
                result = reader.ReadToEnd();
            }
            return result;
        }

        
        public string createUserStory(string usname, string priority, string points, string description,string comments,string projectid,string token)
        {
            string result = String.Empty;
            WebRequest web = WebRequest.Create("http://localhost:5000/USCreate" + "?UserStoryName=" + usname + "&priority=" + priority + "&points=" + points+ "&description=" +description+"&comments="+comments+"&projectid="+projectid);

            web.ContentType = "text/plain";
            web.Method = "POST";
            web.Headers.Add("AUthorization", token);
            var response = (HttpWebResponse)web.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var reader = new StreamReader(response.GetResponseStream());
                result = reader.ReadToEnd();
            }
            return result;
        }

        public string createDefect(string DefectName, string priority, string UserStoryNumber, string description, string comments, string usid,string token)
        {
            string result = String.Empty;
            WebRequest web = WebRequest.Create("http://localhost:5000/DefectCreate" + "?DefectName=" + DefectName + "&priority=" + priority + "&UserStoryNumber=" + UserStoryNumber+ "&description="+ description+"&comments="+comments+"&usid="+usid);

            web.ContentType = "text/plain";
            web.Method = "POST";
            web.Headers.Add("AUthorization", token);
            var response = (HttpWebResponse)web.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var reader = new StreamReader(response.GetResponseStream());
                result = reader.ReadToEnd();
            }
            return result;
        }
        public string saveUS(string usname, string usstatus, string UserStoryNumber, string description,string token)
        {
            string result = String.Empty;
            WebRequest web = WebRequest.Create("http://localhost:5000/SaveUS" + "?usname=" + usname + "&usstatus=" + usstatus + "&UserStoryNumber=" + UserStoryNumber + "&description=" + description);

            web.ContentType = "text/plain";
            web.Method = "POST";
            web.Headers.Add("AUthorization", token);
            var response = (HttpWebResponse)web.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var reader = new StreamReader(response.GetResponseStream());
                result = reader.ReadToEnd();
            }
            return result;
        }

        public string saveDefect(string DefectName, string defno, string defstatus, string description, string token)
        {
            string result = String.Empty;
            WebRequest web = WebRequest.Create("http://localhost:5000/SaveDefect" + "?DefectName=" + DefectName + "&defno=" + defno + "&defstatus=" + defstatus + "&description=" + description);

            web.ContentType = "text/plain";
            web.Method = "POST";
            web.Headers.Add("AUthorization", token);
            var response = (HttpWebResponse)web.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var reader = new StreamReader(response.GetResponseStream());
                result = reader.ReadToEnd();
            }
            return result;
        }

        public List<Dashboard> GetDashboard(string token)
        {
            List<Dashboard> list = new List<Dashboard>();
            string result = String.Empty;
            WebRequest web = WebRequest.Create("http://localhost:5000/Dashboard");

            web.ContentType = "text/plain";
            web.Method = "GET";
            web.Headers.Add("AUthorization", token);
            var response = (HttpWebResponse)web.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var reader = new StreamReader(response.GetResponseStream());
                result = reader.ReadToEnd();
                Dashboard dashboard = JsonConvert.DeserializeObject<Dashboard>(result);
                list.Add(dashboard);
            }
            return list;
        }
    }
}
