using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Infrastructure;

namespace Persistance
{
    internal class RiskOperation : IRisk
    {
        public List<Risk> GetRisksByPolicyId(int policyId)
        {
            return new List<Risk>();
        }
    }
}
