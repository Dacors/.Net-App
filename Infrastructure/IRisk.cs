using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public interface IRisk
    {
        List<Risk> GetRisksByPolicyId(int policyId);
    }
}
