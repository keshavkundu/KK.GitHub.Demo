/* 
 Created By:        Keshav Kundu
 Created Date:      03-10-2021
 Modified Date:     NA
 Purpose:           This class is used as a model for the user inputs.
 Purpose Type:      This model is using get set properties.
 Referenced files:  GithubDemo.cs and authenticationHelper.cs file.
 */
using System.ComponentModel.DataAnnotations;

namespace KK.GitHub.Demo.ClassFiles.Model
{
    public class UserInput
    {
        private string _gitUrl;
        [Required]
        public string UserName { get; set; }
        [Required]
        public string UserToken { get; set; }
        [Required]
        public string GitUrl
        {
            get { return _gitUrl; } 
            set
            {
                value = value + "##";
                //To ensure that this is the last character as .git might be present in between
                if (value.ToLower().IndexOf(".git##") > -1)
                    _gitUrl = value.ToLower().Replace(".git##", "");
                else
                    _gitUrl = value.ToLower().Replace("##", ""); ;

            }
        }
    }
}
