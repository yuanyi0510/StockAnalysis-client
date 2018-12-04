using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Data;

namespace StockAnalysis2._0
{
    class HttpUrl
    {
        //http的get请求。返回json字符串
        public static string GET(string url,Dictionary<String,String> param)
        {
            if (param!=null){
                url = url + "?";
                foreach(var item in param)
                {
                    url += url + item.Key + "="+item.Value+"&";
                }
                url = url.Substring(0, url.Length - 1);
            }
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;//创建请求
            request.Method = "GET";//请求方法为GET
            HttpWebResponse res;//定义返回的response
            try {
                res = (HttpWebResponse)request.GetResponse();//发送请求并获得响应
            }
            catch (WebException ex)
            {
                res = (HttpWebResponse)ex.Response;
            }
            StreamReader sr = new StreamReader(res.GetResponseStream(),Encoding.UTF8);
            string content = sr.ReadToEnd();//响应转化为string字符串
            return content;
        }
        public static string POST(string url,Dictionary<String, String> param)
        {
            //创建请求
            HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest;
            CookieContainer cookie = new CookieContainer();
            req.CookieContainer = cookie;
            req.MaximumResponseHeadersLength = 1024;
            req.Method = "POST";
            req.AllowAutoRedirect = true;
            req.ContentType = "application/json";

            JObject json = new JObject();
            if (param.Count != 0)
            {
                foreach(var item in param)
                {
                    json.Add(item.Key, item.Value);
                }
            }
            string jsonstring = json.ToString();//获得参数的json字符串
            byte[] jsonbyte = Encoding.UTF8.GetBytes(jsonstring);
            Stream poststream = req.GetRequestStream();
            poststream.Write(jsonbyte, 0, jsonbyte.Length);
            poststream.Close();
            //发送请求并获取相应的回应数据
            HttpWebResponse res;
            try
            {
                res = (HttpWebResponse)req.GetResponse();
            }catch(WebException ex)
            {
                res = (HttpWebResponse)ex.Response;
            }
            StreamReader sr = new StreamReader(res.GetResponseStream(), Encoding.UTF8);
            string content = sr.ReadToEnd();
            return content;
        }
        //将json转化为datatable
        public static DataTable JsonToDataTable(string response)
        {
            JObject json = JObject.Parse(response);
            IEnumerable<JProperty> properties = json.Properties();
            JArray ay = new JArray();
            DataTable dt = new DataTable();
            foreach(JProperty item in properties)
            {
                JObject child = JObject.Parse(item.Value.ToString());
                ay.Add(child);
            }
            dt = JsonConvert.DeserializeObject<DataTable>(ay.ToString());
            return dt;
        }


    }

}
