using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure;
using Entities;
using System.Linq;

namespace Persistance
{
    internal class PolicyOperation : IPolicy
    {

        public List<Policy> GetPolicies()
        {
            using (var context = new DataPersistance.Context())
            {
                return context.Set<Policy>().ToList();
            }
                
        }
        public Policy UpdatePolicyPremium(double premium, int policyId)
        {
            using (var context = new DataPersistance.Context())
            {
                Policy policy = context.Set<Policy>().Where(x => x.Id == policyId).FirstOrDefault();
                policy.PremiumIncome = premium;
                context.SaveChanges();

                return policy;
            }
        }

    }
}
