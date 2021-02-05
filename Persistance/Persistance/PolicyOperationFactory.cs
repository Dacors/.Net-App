using Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistance
{
    public static class PolicyOperationFactory
    {
        public static IPolicy GetPolicyOperation() => new PolicyOperation();

        public static IRisk GetRiskOperation() => new RiskOperation();
    }
}
