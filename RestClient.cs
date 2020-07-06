using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Atlassian;
using System.Web;

namespace REST_API_CALL
{
    
    public enum httpVerb
    {
        GET,
        POST,
        DELETE,
        PUT,
        PATCH
    }

    public enum authenticationType
    {
        Basic,
        NTLM
    }

    public enum authenticationTechnique
    {
        RollYourOwn,
        NetworkCredential
    }
    class RestClient
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }

        public authenticationType authType { get; set; }
        public authenticationTechnique authTechnique { get; set; }

        public string userName { get; set; }

        public string userpassWord { get; set; }

        public string postJSON { get; set; }

        public string makeRequest()
        {
            HttpWebResponse response = null;

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string strResponse = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);
            request.UserAgent = userName;
            request.Method = httpMethod.ToString();
            request.ClientCertificates = new System.Security.Cryptography.X509Certificates.X509CertificateCollection();
            request.ServerCertificateValidationCallback += (se, cert, chain, sslerror) => { return true; };
            String authHeader = System.Convert.ToBase64String(System.Text.UTF8Encoding.UTF8.GetBytes(userName + ":" + userpassWord));
            request.Headers.Add("Authorization", "Basic " + authHeader);

            if (request.Method == "POST" && postJSON != string.Empty)
            {
                request.ContentType = "application/json";
                try
                {
                    using (StreamWriter swJSONPayLoad = new StreamWriter(request.GetRequestStream()))
                    {
                        swJSONPayLoad.Write(postJSON);
                        swJSONPayLoad.Close();
                    }
                }
                catch (System.Net.WebException ex)
                {
                    strResponse = ex.ToString();
                }

                finally
                {
                    if (response != null)
                    {
                        ((IDisposable)response).Dispose();
                    }
                }
                

            }
            if (request.Method == "GET" && postJSON == string.Empty)
            {
                try
                {
                    response = (HttpWebResponse)request.GetResponse();

                    //Process the reponse stream (it could be JSON, XML, HTML)

                    using (Stream responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                strResponse = reader.ReadToEnd();
                            }
                        }
                    }
                }
                catch (System.Net.WebException ex)
                {
                    strResponse = ex.ToString();
                }

                finally
                {
                    if (response != null)
                    {
                        ((IDisposable)response).Dispose();
                    }
                }
            }
            
            return strResponse;
        }
    }
}
