﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bt.Models.ViewModel
{
    public class GnmViewModel
    {
        [Column("Applicant_Id")]
        public int ApplicantId { get; set; }

        [Column("Aplicant_Name")]
        [Required(ErrorMessage ="This feild is required")]
        [DisplayName("Applicant Name")]
        [StringLength(50)]
        public string? AplicantName { get; set; }

        [Column("DOB", TypeName = "date")]
        public DateTime? Dob { get; set; }

        [Column("Permanent_State")]
        public int? PermanentState { get; set; }

        [Column("Permanent_District")]
        public int? PermanentDistrict { get; set; }

        [Column("Permanent_Block")]
        public int? PermanentBlock { get; set; }

        [Column("Permanent_Village")]
        public int? PermanentVillage { get; set; }

        [Column("Permanent_Address")]
        [StringLength(50)]
        public string? PermanentAddress { get; set; }

        [Column("Present_State")]
        public int? PresentState { get; set; }

        [Column("Present_District")]
        public int? PresentDistrict { get; set; }

        [Column("Present_Block")]
        public int? PresentBlock { get; set; }

        [Column("Present_Village")]
        public int? PresentVillage { get; set; }

        [Column("Present_Address")]
        [StringLength(50)]
        public string? PresentAddress { get; set; }

        [Column("eMail")]
        [StringLength(100)]
        public string? EMail { get; set; }

        [StringLength(10)]
        public string? Mobile { get; set; }

        public int? Nationality { get; set; }

        public int? Category { get; set; }

        public char? Gender { get; set; }
        public int? Religion { get; set; }

        [Column("Passport_Photo")]
        public IFormFile? PassportPhoto { get; set; }
        [Column("PR_Cetificate")]
        public IFormFile? PrCetificate { get; set; }
        [Column("Category_Certificate")]
        public IFormFile? CategoryCertificate { get; set; }
        public IFormFile? AgeProof { get; set; }
        public IFormFile? Marksheet { get; set; }
        [Column("Character_Certificate")]
        public IFormFile? CharacterCertificate { get; set; }

        [Column("Guardian_Name")]
        [StringLength(50)]
        public string? GuardianName { get; set; }

        [Column("Guardian_Occupation")]
        [StringLength(100)]
        public string? GuardianOccupation { get; set; }

        [Column("Guardian_OfficeName")]
        [StringLength(100)]
        public string? GuardianOfficeName { get; set; }

        [Column("Guardian_OfficeAddress")]
        [StringLength(200)]
        public string? GuardianOfficeAddress { get; set; }

        [Column("Guardian_EmployerCertificate")]
        public IFormFile? GuardianEmployerCertificate { get; set; }

        [StringLength(10)]
        public string? Stream { get; set; }

        [Column("Percentage_XII")]
        public double? PercentageXii { get; set; }

        [StringLength(1)]
        public string? PhysicalDisability { get; set; }

        [Column("Disability_Certificate")]
        public IFormFile? DisabilityCertificate { get; set; }

        public int? ApplicationStatus { get; set; }

        [StringLength(100)]
        public string? Remarks { get; set; }
    }
}
