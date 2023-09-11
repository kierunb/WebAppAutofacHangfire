using Hangfire;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppAutofacHangfire.Jobs;
using WebAppAutofacHangfire.Services;

namespace WebAppAutofacHangfire.Controllers
{
    public class HomeController : Controller
    {
        private readonly TestService _testService;
        private readonly IJob _secondJob;

        public HomeController(
            TestService testService,
            IJob secondJob
            )
        {
            _testService = testService;
            _secondJob = secondJob;
        }

        public ActionResult Index()
        {
            var res = _testService.GetTest();
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            RecurringJob.AddOrUpdate(
                "myrecurringjob",
                () => _secondJob.Execute(),
                Cron.Minutely);

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}