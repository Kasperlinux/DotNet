using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Bt.Data;
using Bt.Models;
using Bt.Models.ViewModel;

namespace Bt.Controllers
{
    public class ApplicantsGnmsController : Controller
    {
        private readonly DhsMagacoursesContext _context;

        public ApplicantsGnmsController(DhsMagacoursesContext context)
        {
            _context = context;
        }

        // GET: ApplicantsGnms
        public async Task<IActionResult> Index()
        {
              return _context.ApplicantsGnms != null ? 
                          View(await _context.ApplicantsGnms.ToListAsync()) :
                          Problem("Entity set 'DhsMagacoursesContext.ApplicantsGnms'  is null.");
        }

        

        // GET: ApplicantsGnms/AddOrEdit
        // GET: ApplicantsGnms/AddOrEdit/5
        public async Task<IActionResult> AddOrEdit(int id=0)
        {
            if(id==0)
            return View(new GnmViewModel());
            else
            {
                var applicantsGnm = await _context.ApplicantsGnms.FindAsync(id);
                if (applicantsGnm==null)
                {
                    return NotFound();
                }
                return View(applicantsGnm);
            }
        }

        

       

        // POST: ApplicantsGnms/AddOrEdit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit(int id, [Bind("ApplicantId,AplicantName,Dob,PermanentState,PermanentDistrict,PermanentBlock,PermanentVillage,PermanentAddress,PresentState,PresentDistrict,PresentBlock,PresentVillage,PresentAddress,EMail,Mobile,Nationality,Category,Gender,Religion,PassportPhoto,PrCetificate,CategoryCertificate,AgeProof,Marksheet,CharacterCertificate,GuardianName,GuardianOccupation,GuardianOfficeName,GuardianOfficeAddress,GuardianEmployerCertificate,Stream,PercentageXii,PhysicalDisability,DisabilityCertificate,ApplicationStatus,Remarks,DataEntryTimestamp,DataEntryIp,ModifiedBy,ModifiedTimestamp,ModifiedIp,AgeAsOnCutOffDate")] ApplicantsGnm applicantsGnm)
        {

            if (ModelState.IsValid)
            {
                if (id==0)
                {
                    _context.Add(applicantsGnm);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    try
                    {
                        _context.Update(applicantsGnm);
                        await _context.SaveChangesAsync();
                    }
                    catch (DbUpdateConcurrencyException)
                    {
                        if (!ApplicantsGnmExists(applicantsGnm.ApplicantId))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                
                return Json(new {isValid=true,html = Helper.RenderRazorViewToString(this, "_ViewAll", _context.ApplicantsGnms.ToList()) });
            }
            return Json(new { isValid = false, html = Helper.RenderRazorViewToString(this, "AddOrEdit", applicantsGnm) });
        }

        // GET: ApplicantsGnms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ApplicantsGnms == null)
            {
                return NotFound();
            }

            var applicantsGnm = await _context.ApplicantsGnms
                .FirstOrDefaultAsync(m => m.ApplicantId == id);
            if (applicantsGnm == null)
            {
                return NotFound();
            }

            return View(applicantsGnm);
        }

        // POST: ApplicantsGnms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ApplicantsGnms == null)
            {
                return Problem("Entity set 'DhsMagacoursesContext.ApplicantsGnms'  is null.");
            }
            var applicantsGnm = await _context.ApplicantsGnms.FindAsync(id);
            if (applicantsGnm != null)
            {
                _context.ApplicantsGnms.Remove(applicantsGnm);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ApplicantsGnmExists(int id)
        {
          return (_context.ApplicantsGnms?.Any(e => e.ApplicantId == id)).GetValueOrDefault();
        }
    }
}
