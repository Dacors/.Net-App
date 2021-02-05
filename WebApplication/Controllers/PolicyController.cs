using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities;
using Newtonsoft.Json;

namespace WebApplication.Controllers
{
    public class PolicyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetPolicies()
        {
            try
            {
                List<Policy> policies = Persistance.PolicyOperationFactory.GetPolicyOperation().GetPolicies();
                return Json(new { PremiumIncome = policies });
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

        [HttpPost]
        public ActionResult UpdatePolicyPremium([FromBody] dynamic parameters)
        {
            try
            {
                double policyPremium = (double)parameters["policyPremium"];
                int policyId = (int)parameters["policyId"];
                Policy policy = Persistance.PolicyOperationFactory.GetPolicyOperation().UpdatePolicyPremium(policyPremium, policyId);
                return Json(new { Policy = policy });
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
