using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp3.DomainClass;

[Table("MoiQuanHe")]
[Index("Ma", Name = "UQ__MoiQuanH__3214CC9E2C585F5D", IsUnique = true)]
public partial class MoiQuanHe
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Ma { get; set; }

    [StringLength(50)]
    public string? Ten { get; set; }

    [InverseProperty("IdMqhNavigation")]
    public virtual ICollection<Ban> Bans { get; set; } = new List<Ban>();
}
