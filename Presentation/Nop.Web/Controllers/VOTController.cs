using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Nop.Web.Controllers
{
    public class VOTController : BasePublicController
    {
        public  IActionResult VOT()
        {
            return View();
        }
    }
}