using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using WhizCrafts.Collab.Repository;
using Microsoft.Practices.SharePoint.Common.ServiceLocation;
using System.Collections.Generic;


namespace WhizCrafts.Collab.WebParts.IssuesList
{
    public partial class IssuesListUserControl : UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            using (var issueManagementRepository = SharePointServiceLocator.GetCurrent().GetInstance<IIssueManagementRepository>())
            {
                IEnumerable<Issues> issues = issueManagementRepository.GetIssues();
                lbIssues.DataSource = issues;
                lbIssues.DataTextField = "Title";
                lbIssues.DataValueField = "Title";


                lbIssues.DataBind();

            }
        }
    }
}
