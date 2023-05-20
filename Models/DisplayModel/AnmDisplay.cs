using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bt.Models.DisplayModel
{
    public class AnmDisplay
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Applicant_Id")]
        public int ApplicantId { get; set; }

        [Column("Aplicant_Name")]
        [StringLength(50)]
        public string? AplicantName { get; set; }

        [Column("DOB", TypeName = "date")]
        public DateTime? Dob { get; set; }

        [Column("Permanent_State")]
        public string? PermanentState { get; set; }

        [Column("Permanent_District")]
        public string? PermanentDistrict { get; set; }

        [Column("Permanent_Block")]
        public string? PermanentBlock { get; set; }

        [Column("Permanent_Village")]
        public string? PermanentVillage { get; set; }

        [Column("Permanent_Address")]
        [StringLength(50)]
        public string? PermanentAddress { get; set; }

        [Column("Present_State")]
        public string? PresentState { get; set; }

        [Column("Present_District")]
        public string? PresentDistrict { get; set; }

        [Column("Present_Block")]
        public string? PresentBlock { get; set; }

        [Column("Present_Village")]
        public string? PresentVillage { get; set; }

        [Column("Present_Address")]
        [StringLength(50)]
        public string? PresentAddress { get; set; }

        [Column("eMail")]
        [StringLength(100)]
        public string? EMail { get; set; }

        [StringLength(10)]
        public string? Mobile { get; set; }

        public string? Nationality { get; set; }

        public string? Category { get; set; }

        public char? Gender { get; set; }

        public string? Religion { get; set; }

        [Column("Passport_Photo", TypeName = "image")]
        public byte[]? PassportPhoto { get; set; }

        [Column("PR_Cetificate")]
        public byte[]? PrCetificate { get; set; }

        [Column("Category_Certificate")]
        public byte[]? CategoryCertificate { get; set; }

        public byte[]? AgeProof { get; set; }

        public byte[]? Marksheet { get; set; }

        [Column("Character_Certificate")]
        public byte[]? CharacterCertificate { get; set; }

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
        public byte[]? GuardianEmployerCertificate { get; set; }

        [StringLength(10)]
       
        public string? Stream { get; set; }

        [Column("Percentage_XII")]
        public double? PercentageXii { get; set; }

        public string? ApplicationStatus { get; set; }

        [StringLength(100)]
        public string? Remarks { get; set; }


        public int? AgeAsOnCutOffDate { get; set; }
    }
}
