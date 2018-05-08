using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Nop.Web.Controllers
{
    public class VerificationOfThingsController : BasePublicController
    {
        public IActionResult VerificationOfThings()
        {
            return View();
        }
    }
}