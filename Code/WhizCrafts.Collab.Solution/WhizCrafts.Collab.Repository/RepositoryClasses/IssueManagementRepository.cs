


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;

namespace WhizCrafts.Collab.Repository
{

    public class IssueManagementRepository : IIssueManagementRepository
    {

        private IssuesDataContext dataContext { get; set; }

        public IssueManagementRepository(IssuesDataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public IssueManagementRepository()
        {
            dataContext = new IssuesDataContext(SPContext.Current.Web.Url);
        }


        public IEnumerable<Issues> GetIssues()
        {
            return dataContext.Issues.OrderBy(p => p.Title);
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                 //free managed resources
                if (dataContext != null)
                {
                    dataContext.Dispose();
                    dataContext = null;
                }
            }
        }
    
    }
}

