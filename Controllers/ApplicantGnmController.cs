using Bt.Data;
using Bt.Models.ViewModel;
using Bt.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bt.Controllers
{
    public class ApplicantGnmController : Controller
    {
        private readonly DhsMagacoursesContext context;
        private readonly IWebHostEnvironment environment;
        private readonly ILogger<ApplicantAnmController> _logger;

        public ApplicantGnmController(DhsMagacoursesContext context, IWebHostEnvironment environment, ILogger<ApplicantAnmController> logger)
        {
            this.context=context;
            this.environment=environment;
            _logger=logger;
        }

        public JsonResult State()
        {
            var cnt = context.MStates.ToList();
            return new JsonResult(cnt);
        }

        public JsonResult District(int id)
        {
            var dt = context.MDistricts.Where(e => e.StateCode==id).ToList();
            return new JsonResult(dt);
        }

        public JsonResult Block(int id)
        {
            var bk = context.MBlocks.Where(e => e.DistrictCode==id).ToList();
            return new JsonResult(bk);
        }

        public JsonResult Village(int id)
        {
            var vg = context.MVillages.Where(e => e.BlockCode==id).ToList();
            return new JsonResult(vg);
        }

        public JsonResult Nationality()
        {
            var data = context.MNationalities.ToList();
            return new JsonResult(data);
        }
        public JsonResult GetNationalityName(int id)
        {
            var dt = context.MNationalities.Where(e => e.Nationality==id);
            return new JsonResult(dt);
        }
        public JsonResult GetReligionName(int id)
        {
            var dt = context.MReligions.Where(e => e.Religion==id);
            return new JsonResult(dt);
        }
        public JsonResult GetCategoryName(int id)
        {
            var dt = context.MCategories.Where(e => e.Category==id);
            return new JsonResult(dt);
        }
        public JsonResult GetStateName(int id)
        {
            var dt = context.MStates.Where(e => e.StateCode==id);
            return new JsonResult(dt);
        }
        public JsonResult GetDistrictName(int id)
        {
            var dt = context.MDistricts.Where(e => e.DistrictCode==id);
            return new JsonResult(dt);
        }
        public JsonResult GetBlockName(int id)
        {
            var dt = context.MBlocks.Where(e => e.BlockCode==id);
            return new JsonResult(dt);
        }
        public JsonResult GetVillageName(int id)
        {
            var dt = context.MVillages.Where(e => e.VillageCode==id);
            return new JsonResult(dt);
        }

        //public IActionResult GetNationalityName(int? nationality)
        //{
        //    if (nationality==null)
        //    {
        //        return BadRequest("Nationality parameter is missing.");
        //    }

        //    var nationalityObj = context.MNationalities.FirstOrDefault(n => n.Nationality==nationality);

        //    if (nationalityObj==null)
        //    {
        //        return NotFound($"Nationality {nationality} not found.");
        //    }

        //    return Ok(nationalityObj.NationalityName);
        //}

        public JsonResult Category()
        {
            var data = context.MCategories.ToList();
            return new JsonResult(data);
        }

        public JsonResult Gender()
        {
            var data = context.MGenders.ToList();
            return new JsonResult(data);
        }

        public JsonResult Religion()
        {
            var data = context.MReligions.ToList();
            return new JsonResult(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateAdmin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(GnmViewModel model)
        {

            if (ModelState.IsValid)
            {
                // Calculate age based on date of birth
                int age = 0;
                if (model.Dob!=null)
                {
                    var today = DateTime.Today;
                    var dob = (DateTime)model.Dob; // cast to non-nullable DateTime
                    age=today.Year-dob.Year;
                    if (dob>today.AddYears(-age))
                    {
                        age--;
                    }
                }


                var dataBase = new ApplicantsGnm()
                {
                    AplicantName=model.AplicantName,
                    Dob=model.Dob,

                    PermanentState=model.PermanentState,
                    PermanentDistrict=model.PermanentDistrict,
                    PermanentBlock=model.PermanentBlock,
                    PermanentVillage=model.PermanentVillage,
                    PermanentAddress=model.PermanentAddress,

                    PresentState=model.PresentState,
                    PresentDistrict=model.PresentDistrict,
                    PresentBlock=model.PresentBlock,
                    PresentVillage=model.PresentVillage,
                    PresentAddress=model.PresentAddress,

                    EMail=model.EMail,
                    Mobile=model.Mobile,

                    Nationality=model.Nationality,
                    Category=model.Category,
                    Gender=model.Gender,
                    Religion=model.Religion,

                    PassportPhoto=ConvertImageToByteArray(model.PassportPhoto),
                    PrCetificate=ConvertImageToByteArray(model.PrCetificate),
                    CategoryCertificate=ConvertImageToByteArray(model.CategoryCertificate),
                    AgeProof=ConvertImageToByteArray(model.AgeProof),
                    Marksheet=ConvertImageToByteArray(model.Marksheet),
                    CharacterCertificate=ConvertImageToByteArray(model.CharacterCertificate),


                    GuardianName=model.GuardianName,
                    GuardianOfficeName=model.GuardianOfficeName,
                    GuardianOfficeAddress=model.GuardianOfficeAddress,
                    GuardianOccupation=model.GuardianOccupation,
                    GuardianEmployerCertificate=ConvertImageToByteArray(model.GuardianEmployerCertificate),

                    Stream=model.Stream,
                    PercentageXii=model.PercentageXii,
                    //PhysicalDisability=model.PhysicalDisability,
                    //DisabilityCertificate=ConvertImageToByteArray(model.DisabilityCertificate),
                    PhysicalDisability="N",
                    DisabilityCertificate=null,
                    ApplicationStatus=1,

                    AgeAsOnCutOffDate=age,

                    DataEntryTimestamp=DateTime.Now,
                    DataEntryIp=Request.HttpContext.Connection.RemoteIpAddress.ToString()
                };
                context.Add(dataBase);
                context.SaveChanges();
                return RedirectToAction("Display");
            }
            else
            {
                return View(model);
            }
        }
        public byte[] ConvertImageToByteArray(IFormFile imageFile)
        {
            using (var stream = new MemoryStream())
            {
                imageFile.CopyTo(stream);
                return stream.ToArray();
            }
        }


        //Original
        public IActionResult Display()
        {
            var applicants = context.ApplicantsGnms.ToList();
            return View(applicants);
        }



        [HttpGet]
        public IActionResult Index()
        {
            var applicants = context.ApplicantsGnms.ToList();
            return View(applicants);
        }
    }
}
