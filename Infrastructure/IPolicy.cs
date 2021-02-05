using System;
using System.Collections.Generic;
using System.Text;
using Entities;

namespace Infrastructure
{
    public interface IPolicy
    {
        List<Policy> GetPolicies();
        Policy UpdatePolicyPremium(double premium, int policyId);
    }
}
