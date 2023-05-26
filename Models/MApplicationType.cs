using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Bt.Models;


[Table("mApplicationType")]
public partial class MApplicationType
{
    [Key]
    public int ApplicationType { get; set; }

    [Column("Application_Desc")]
    [StringLength(60)]
    public string ApplicationDesc { get; set; } = null!;
}
