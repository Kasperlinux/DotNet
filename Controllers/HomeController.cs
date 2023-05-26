using Bt.Data;
using Bt.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DhsMagacoursesContext context;
        private readonly IWebHostEnvironment environment;
        

        public HomeController(DhsMagacoursesContext context, IWebHostEnvironment environment, ILogger<HomeController> logger)
        {
            this.context=context;
            this.environment=environment;
            _logger=logger;
        }

       

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index_All()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId=Activity.Current?.Id??HttpContext.TraceIdentifier });
        }

        //My Actions
        public IActionResult CountRecords()
        {
            var recordCountAnm = context.ApplicantsAnms.Count();
            var recordCountGnm = context.ApplicantsGnms.Count();
            var recordCountMbbs = context.ApplicantsMbbs.Count();
            var recordCountAllied = context.ApplicantsAlliedCourses.Count();

            var result = new
            {
                RecordCountAnm = recordCountAnm,
                RecordCountGnm = recordCountGnm,
                RecordCountMbbs = recordCountMbbs,
                RecordCountAllied = recordCountAllied
            };

            return Json(result);
        }
    }
}