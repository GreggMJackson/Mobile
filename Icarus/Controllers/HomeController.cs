using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Icarus.Controllers {
    public class HomeController : Controller {

        public ActionResult Index() => View();
        public ActionResult About() => View();
        public ActionResult Contact() => View();

        public ActionResult Javascript() => View("Javascript");
        public ActionResult Mobile() => View("Mobile");
        public ActionResult Cloud() => View("Cloud");
        public ActionResult BigData() => View("BigData");
        public ActionResult IoT() => View("IoT");
        public ActionResult BlockChain() => View("BlockChain");
        public ActionResult AI() => View("AI");

    }
}