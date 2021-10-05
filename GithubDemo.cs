using KK.GitHub.Demo.ClassFiles.ExtensionFiles;
using KK.GitHub.Demo.ClassFiles.HelperFiles;
using KK.GitHub.Demo.ClassFiles.LogicFiles;
using KK.GitHub.Demo.ClassFiles.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace KK.GitHub.Demo
{
    public partial class GithubDemo : Form
    {
        #region Private Variables
        private UserInput userInput = null;
        DataTable dataTableFromBinaryTree = null;
        #endregion

        public GithubDemo()
        {
            InitializeComponent();
        }

        #region Application Events
        private void btnValidateInput_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidationSuccess()) //To check if input parameter is valid or not
                {
                    string responseResult = AuthenticationHelper.GetInstance.AuthenticateUser(userInput);
                    if (responseResult != null)
                    {
                        var gitResponses = JsonConvert.DeserializeObject<List<GitModelCommit>>(responseResult);
                        if (gitResponses != null && gitResponses.Count > 0)
                        {
                            BinarySearchTree binarySearch = new BinarySearchTree();
                            foreach (GitModelCommit gitResponse in gitResponses)
                            {
                                string[] commentWords = gitResponse.commit.message.Split();
                                for (int i = 0; i < commentWords.Length; i++)
                                {
                                    binarySearch.AddNode(commentWords[i].Trim());
                                }
                            }

                            //Bubble Sort the responses
                            dataTableFromBinaryTree = BinarySearchTree.ConvertBinaryTreeToList(binarySearch.Root).SortAndBindListToDataTable();
                            EnableDisableFieldsAfterResponse();
                        }
                        else
                        {
                            MessageBox.Show("No result found..", "Authentication Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Authentication unsuccessful..", "Authentication Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                LogExceptionForApplication(ex);
            }
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            try
            {
                dataTableFromBinaryTree.ExportToCSV(AppDomain.CurrentDomain.BaseDirectory);
                OpenFolderPath();
            }
            catch (Exception ex)
            {
                LogExceptionForApplication(ex);
            }
        }

        #endregion

        #region Common private methods
        private void OpenFolderPath()
        {
            if (!DirectoryHelper.GetInstance.OpenFolder(AppDomain.CurrentDomain.BaseDirectory))
                MessageBox.Show(string.Format("{0} Directory does not exist!", AppDomain.CurrentDomain.BaseDirectory));
        }

        private void LogExceptionForApplication(Exception ex)
        {
            if (!ex.LogException(AppDomain.CurrentDomain.BaseDirectory))
            {
                MessageBox.Show(string.Format("Unable to log exception! Original exception: {0}",
                    ex.Message));
            }
            else
            {
                MessageBox.Show("An exception has occurred! Please see the log file for more information."); ;
                OpenFolderPath();
            }

        }

        private bool ValidationSuccess()
        {
            //Hide the label first when clicked
            lblErrorUserName.Visible = false;
            lblErrorGitUrl.Visible = false;
            lblErrorToken.Visible = false;

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
            {
                userInput = new UserInput()
                {
                    GitUrl = txtGitUrl.Text,
                    UserName = txtUserName.Text,
                    UserToken = txtToken.Text
                };
                return true;
            }

        }

        private void EnableDisableFieldsAfterResponse()
        {
            txtGitUrl.Enabled = false;
            txtToken.Enabled = false;
            txtUserName.Enabled = false;
            btnValidateInput.Enabled = false;
            lblCommentHeader.Visible = true;
            lblInformation.Visible = false;
            lblLeftHeading.Text = "Authentication successful.";
            dataGridView.DataSource = dataTableFromBinaryTree;
            dataGridView.Visible = true;
            btnExportCSV.Visible = true;
        }
        #endregion
    }
}
