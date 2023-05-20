namespace Bt.Models.DisplayModel
{
    public class ApplicantsViewModel
    {
        public int ApplicantId { get; set; }
        public string AplicantName { get; set; }
        public DateTime? Dob { get; set; }
        public string? PermanentState { get; set; }
        public string? PermanentDistrict { get; set; }
        public string? PermanentBlock { get; set; }
        public string? PermanentVillage { get; set; }
        public string PermanentAddress { get; set; }
        public string? PresentState { get; set; }
        public string? PresentDistrict { get; set; }
        public string? PresentBlock { get; set; }
        public string? PresentVillage { get; set; }
        public string PresentAddress { get; set; }
        public string EMail { get; set; }
        public string Mobile { get; set; }
        public string? Nationality { get; set; }
        public string? Category { get; set; }
        public string? Gender { get; set; }
        public string? Religion { get; set; }
        public byte[] PassportPhoto { get; set; }
        public byte[] PrCetificate { get; set; }
        public byte[] CategoryCertificate { get; set; }
        public byte[] AgeProof { get; set; }
        public byte[] Marksheet { get; set; }
        public byte[] CharacterCertificate { get; set; }
        public string GuardianName { get; set; }
        public string GuardianOccupation { get; set; }
        public string GuardianOfficeName { get; set; }
        public string GuardianOfficeAddress { get; set; }
        public byte[] GuardianEmployerCertificate { get; set; }
        public string Stream { get; set; }
        public double? PercentageXii { get; set; }
        public int? ApplicationStatus { get; set; }
        public string Remarks { get; set; }
        public DateTime? DataEntryTimestamp { get; set; }
        public string DataEntryIp { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedTimestamp { get; set; }
        public string ModifiedIp { get; set; }
        public int? AgeAsOnCutOffDate { get; set; }

        // Additional properties to hold the image data in base64 format for display in view
        public string PassportPhotoBase64 { get; set; }
        public string PrCetificateBase64 { get; set; }
        public string CategoryCertificateBase64 { get; set; }
        public string AgeProofBase64 { get; set; }
        public string MarksheetBase64 { get; set; }
        public string CharacterCertificateBase64 { get; set; }
        public string GuardianEmployerCertificateBase64 { get; set; }


    }
}
