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
            if (ValidationSuccess())
            {
                string responseResult = AuthenticateUser();
                if (responseResult != null)
                {
                    var gitResponses = JsonConvert.DeserializeObject<List<GitModelCommit>>(responseResult);
                    if (gitResponses != null && gitResponses.Count > 0)
                    {
                        MessageBox.Show("Received response on the details provided! Stay Tuned..", "Result Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Authentication unsuccessful..", "Authentication Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidationSuccess()
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                lblErrorUserName.Visible = true;
            }
            if (string.IsNullOrEmpty(txtGitUrl.Text.Trim()))
            {
                lblErrorGitUrl.Visible = true;
            }
            if (string.IsNullOrEmpty(txtToken.Text.Trim()))
            {
                lblErrorToken.Visible = true;
            }
            if (lblErrorUserName.Visible || lblErrorGitUrl.Visible || lblErrorToken.Visible)
                return false;
            else
                return true;
        }

        private string AuthenticateUser()
        {
            txtGitUrl.Text += "##";//To get the closing Url
            if (txtGitUrl.Text.ToUpper().IndexOf(".GIT##") > 0)
                txtGitUrl.Text = txtGitUrl.Text.ToUpper().Replace(".GIT##", "");
            else
                txtGitUrl.Text = txtGitUrl.Text.Replace("##", "");
            string[] splitGitUrl = txtGitUrl.Text.Split('/');
            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri("https://api.github.com"),

            };
            client.DefaultRequestHeaders.Add("User-Agent", "Anything");
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Token", txtToken.Text);
            var response = client.GetAsync(
                string.Format("/repos/{0}/{1}/commits", txtUserName.Text, splitGitUrl[splitGitUrl.Length - 1])
             ).Result;
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsStringAsync().Result;
            }
            else
                return null;
        }

        class GitModelCommit
        {
            public string comments_url { get; set; }
            public CommitComments commit { get; set; }
        }

        class CommitComments
        {
            public string message { get; set; }

        }


    }
}
