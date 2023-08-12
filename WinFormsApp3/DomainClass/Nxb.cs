using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp3.DomainClass;

[Table("NXB")]
[Index("Ma", Name = "UQ__NXB__3214CC9E1DCAC495", IsUnique = true)]
public partial class Nxb
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Ma { get; set; }

    [StringLength(50)]
    public string? Ten { get; set; }

    [InverseProperty("IdNxbNavigation")]
    public virtual ICollection<Sach> Saches { get; set; } = new List<Sach>();
}
