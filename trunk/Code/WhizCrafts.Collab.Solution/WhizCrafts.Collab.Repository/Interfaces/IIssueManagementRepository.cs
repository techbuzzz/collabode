

using System.Collections.Generic;
using System;

namespace WhizCrafts.Collab.Repository
{
   

    public interface IIssueManagementRepository : IDisposable
    {
        IEnumerable<Issues> GetIssues();
    }
}
