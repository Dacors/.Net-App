using System;
using System.Collections.Generic;

namespace Entities
{
    public class Policy
    {
        public int Id { get; set; }

        public double PremiumIncome { get; set; }

        public int AgencyId { get; set; }

        public int InsuredPersonId { get; set; }

        public int InsuredCompanyId { get; set; }

        public List<Risk> Risks { get; set; }
    }
}
