using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Reflection;

namespace REST_API_CALL
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        //string jquery = "{"fields":{"project":{"key":"TA"},"issuetype":{"name":"Task"},"summary":"[TA]
        //REST API POST","description":"TEST ISSUE ONLY","assignee":{"name":"OliverCesumission"},"components":[{"name":"Test Development"}],"customfield_10324":{"value":"Non-gate Stage/Project"},"priority":{"name":"Medium"},"labels":["PARAMETRIC_TEST"]}}";

        string jquery_url = "http://jira-ep.ecp.priv/rest/api/2/search?jql=assignee=OliverCesumission&fields=id,key";

        RestClient rClient = new RestClient();
        ParseJSON strParse_JSON = new ParseJSON();
        string strResponse = string.Empty;
        string strDeserialize = string.Empty;
        public Form1()
        {
            InitializeComponent();
            ShowLogInDialog();
        }

        void ShowLogInDialog()
        {
            frmLogIn LogCheck = new frmLogIn();
            LogCheck.ShowDialog();
            LogCheck.Dispose();
            Refresh();
        }

        #region UI Event Handlers

        private void btnSearch_Click(object sender, EventArgs e)
        {
            rClient.httpMethod = httpVerb.GET;
            rClient.postJSON = "";
            rClient.endPoint = "http://jira-ep.ecp.priv/rest/api/2/search?jql=assignee=OliverCesumission&fields=id,key";
            rClient.userName = csUserCredential.Instance.UserName;
            rClient.userpassWord = csUserCredential.Instance.Password;

            strResponse = rClient.makeRequest();

            MessageBox.Show(strResponse);

        }

        #endregion

        private void btnCreateRepo_Click(object sender, EventArgs e)
        {

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string strResponse = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://jira-ep.ecp.priv/rest/api/2/search?jql=assignee=" + csUserCredential.Instance.UserName + "&fields=id,key");
            request.UserAgent = csUserCredential.Instance.UserName;
            request.Method = "POST";
            request.UseDefaultCredentials = true;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("ERROR CODE" + response.ToString());
                }

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
                }//End of response stream
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmHtmlWindow _frmHtmlWindow = new frmHtmlWindow();
            _frmHtmlWindow.ShowDialog();
        }

        private void btnPostJira_Click(object sender, EventArgs e)
        {
            csFields.fields.Description = txtFieldDescription.Text;

            csFields.fields.summary = txtFieldSummary.Text;

            csFields.fields.labels = txtFieldLabels.Text;

            csFields.assignee assignee = new csFields.assignee();
            assignee.name = csUserCredential.Instance.UserName;

            csFields.component _components = new csFields.component();
            _components.name = txtFieldComponents.Text;

            csFields.ComponentCollection components = new csFields.ComponentCollection();

            csFields.customfield_10324 customfield_10324 = new csFields.customfield_10324();
            customfield_10324.value = cmbFieldProjectStage.SelectedItem.ToString();

            csFields.issuetype issuetype = new csFields.issuetype();
            issuetype.name = cmbFieldIssueType.SelectedItem.ToString();

            csFields.priority priority = new csFields.priority();
            priority.name = cmbFieldPriority.SelectedItem.ToString();

            csFields.project project = new csFields.project();
            project.key = cmbFieldProjectKey.SelectedItem.ToString();


            string output = JsonConvert.SerializeObject(new { csFields.fields, project, issuetype, assignee, components = new[] { _components }, customfield_10324, priority });
            
            MessageBox.Show(output);

            rClient.httpMethod = httpVerb.POST;


            rClient.endPoint = "http://jira-ep.ecp.priv/rest/api/2/";
            rClient.postJSON = output;
            rClient.userName = csUserCredential.Instance.UserName;
            rClient.userpassWord = csUserCredential.Instance.Password;

            strResponse = rClient.makeRequest();

            MessageBox.Show(strResponse);

            //NEXT is to upload any files if there any available
            rClient.endPoint = "http://jira-ep.ecp.priv/rest/api/2/issueKey/attachments";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}