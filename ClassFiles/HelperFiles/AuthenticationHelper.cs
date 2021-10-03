/* 
 Created By:        Keshav Kundu
 Created Date:      03-10-2021
 Modified Date:     NA
 Purpose:           This class is used for authenticating Github and uses singleton design pattern.
 Purpose Type:      This class retruns response if authenticated else sends null.
 Referenced files:  GithubDemo.cs file.
 */
using KK.GitHub.Demo.ClassFiles.Constants;
using KK.GitHub.Demo.ClassFiles.Model;
using System;
using System.Net.Http;

namespace KK.GitHub.Demo.ClassFiles.HelperFiles
{
    public class AuthenticationHelper
    {
        private static AuthenticationHelper instance;
        private AuthenticationHelper()
        {
        }

        /// <summary>
        /// Locking is not included here as threading is not included.
        /// </summary>
        public static AuthenticationHelper GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AuthenticationHelper();
                }
                return instance;
            }
        }

        /// <summary>
        /// Authenticate the user against Github
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns>Response from Git else null</returns>
        public string AuthenticateUser(UserInput userInput)
        {
            try
            {
                string[] splitGitUrl = userInput.GitUrl.Split('/');
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ApplicationConstants.gitHubUrl);
                    client.DefaultRequestHeaders.Add("User-Agent", "Anything");
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Token", userInput.UserToken);
                    var response = client.GetAsync(
                        string.Format("/repos/{0}/{1}/commits", userInput.UserName, splitGitUrl[splitGitUrl.Length - 1])
                     ).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        return response.Content.ReadAsStringAsync().Result;
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }
    }
}
