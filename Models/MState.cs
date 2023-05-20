using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
namespace Bt.Models;

[Table("mStates")]
public partial class MState
{
    [Key]
    [Column("State_Code")]
    public int StateCode { get; set; }

    [Column("State_Name")]
    [StringLength(60)]
    public string StateName { get; set; } = null!;
}
