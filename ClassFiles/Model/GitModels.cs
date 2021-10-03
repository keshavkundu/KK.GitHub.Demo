/* 
 Created By:        Keshav Kundu
 Created Date:      03-10-2021
 Modified Date:     NA
 Purpose:           GitModelCommit class is used to deserialize JSON response 
                    from GIT using HTTPClient.
 Referenced files:  GithubDemo.cs and Internal reference in GitModel.cs for CommitComments class
 */

namespace KK.GitHub.Demo.ClassFiles.Model
{
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
