using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Barebones.Data;

namespace Barebones.Controllers
{
    public class BoneController : Controller
    {
        // GET: Bone
        public ActionResult Index()
        {
            return View();
        }
    }
}