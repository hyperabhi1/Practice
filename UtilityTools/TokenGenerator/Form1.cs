using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokenGenerator
{
    public partial class FormTokenGenerator : Form
    {
        public FormTokenGenerator()
        {
            InitializeComponent();
        }
        string qnaRAppCD = "JPRS_QUA_A_COR";
        string snbRAppCD = "JPRS_SND_A_COR";
        string prdRAppCD = "JPRS_PRD_A_COR";
        string qnaRAuthServiceURL = "https://sandbox-auth.livecareer.com/";
        string snbRAuthServiceURL = "https://sandbox-auth.livecareer.com/";
        string prdAuthServiceURL = "https://auth.livecareer.com/";
        string qnaRClientSecret = "d2VnZmVqcHJzMTAwMTE5cmU=";
        string snbRClientSecret = "amNuNDVqcHJzMTAwMTE5c2U=";
        string prdRClientSecret = "------------------------";

        private void ResumesEventHandler(object sender, EventArgs e)
        {
            if (radioButtonRQA.Checked)
            {
                textBoxRAppCD.Text = qnaRAppCD;
                textBoxRauthServiceUrl.Text = qnaRAuthServiceURL;
                textBoxRClientSecret.Text = qnaRClientSecret;
                buttonRCopyToken.Enabled = true;
                buttonRGo.Enabled = true;
                textBoxRToken.Enabled = true;
                textBoxRBody.Text = BodyGenerator(qnaRAppCD, qnaRClientSecret);
            }
            else if(radioButtonRSandBox.Checked)
            {
                textBoxRAppCD.Text = snbRAppCD;
                textBoxRauthServiceUrl.Text = snbRAuthServiceURL;
                textBoxRClientSecret.Text = snbRClientSecret;
                buttonRCopyToken.Enabled = true;
                buttonRGo.Enabled = true;
                textBoxRToken.Enabled = true;
                textBoxRBody.Text = BodyGenerator(snbRAppCD, snbRClientSecret);
            }
            else
            {
                textBoxRAppCD.Text = prdRAppCD;
                textBoxRauthServiceUrl.Text = prdAuthServiceURL;
                textBoxRClientSecret.Text = prdRClientSecret;
                buttonRCopyToken.Enabled = false;
                buttonRGo.Enabled = false;
                textBoxRToken.Enabled = false;
                textBoxRBody.Text = BodyGenerator(prdRAppCD, prdRClientSecret);
            }
        }

        private string BodyGenerator(string appCD, string clientSecret)
        {
            return $"grant_type=client_credentials&client_id={appCD}&client_secret={clientSecret}&response_type=token";
        }
        private string URLGenerator(string authServiceURL)
        {
            return $"{authServiceURL}oauth/token";
        }

        private async void buttonRGo_Click(object sender, EventArgs e)
        {
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(URLGenerator(textBoxRauthServiceUrl.Text), new StringContent(BodyGenerator(textBoxRAppCD.Text, textBoxRClientSecret.Text), Encoding.UTF8, "text/plain"));
                var content = await response.Content.ReadAsStringAsync();
                JObject parsedJson = JObject.Parse(content);
                var schema = (string)parsedJson["token_type"];
                var token = (string)parsedJson["access_token_jwt"];
                textBoxRToken.Text = schema + " " + token;
            }
        }

        private void buttonRCopyToken_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxRToken.Text);
        }

        private void FormTokenGenerator_Load(object sender, EventArgs e)
        {

        }
    }
}
