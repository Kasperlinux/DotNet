using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bt.Models;


public partial class AgeEligibilityCriterion
{
    [Key]
    [Column("Session_Code")]
    public int? SessionCode { get; set; }

    public int? Category { get; set; }

    [Column("AgeLimit_Lower")]
    public int? AgeLimitLower { get; set; }

    [Column("AgeLimit_Upper")]
    public int? AgeLimitUpper { get; set; }
}
