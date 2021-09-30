using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KK.GitHub.Demo
{
    public partial class GithubDemo : Form
    {
        public GithubDemo()
        {
            InitializeComponent();
        }

        private void btnValidateInput_Click(object sender, EventArgs e)
        {
            string responseResult = AuthenticateUser();
            if (responseResult != null)
            {
                var gitResponses = JsonConvert.DeserializeObject<List<GitModel>>(responseResult);
                if (gitResponses != null && gitResponses.Count > 0)
                {
                    var gitResponse = gitResponses.Where(x => x.html_url == txtGitUrl.Text).FirstOrDefault();
                    if (gitResponse != null)
                    {
                        MessageBox.Show("Received response on the details provided! Stay Tuned..", "Result Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Authentication successful but details does not match..", "Authentication Successful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }else
            {
                MessageBox.Show("Authentication unsuccessful..", "Authentication Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }

        private string AuthenticateUser()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.github.com");
            client.DefaultRequestHeaders.UserAgent.Add(new System.Net.Http.Headers.ProductInfoHeaderValue("AppName", "1.0"));
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Token", txtToken.Text);
            HttpResponseMessage response = client.GetAsync(string.Format("/users/{0}/repos",txtUserName.Text)).Result;
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result;
            }
            else
                return null;
        }

        class GitModel
        {
            public string git_url { get; set; }
            public string html_url { get; set; }
            public string svn_url { get; set; }
            public string clone_url { get; set; }
            public string description { get; set; }
        }

    }
}
