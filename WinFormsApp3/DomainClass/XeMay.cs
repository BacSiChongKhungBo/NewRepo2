using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp3.DomainClass;

[Table("XeMay")]
[Index("Ma", Name = "UQ__XeMay__3214CC9E80283DDD", IsUnique = true)]
public partial class XeMay
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Ma { get; set; }

    [StringLength(30)]
    public string? Ten { get; set; }

    [Column("NgaySX", TypeName = "date")]
    public DateTime? NgaySx { get; set; }

    [StringLength(30)]
    public string? Mota { get; set; }

    [Column(TypeName = "decimal(20, 0)")]
    public decimal? GiaNhap { get; set; }

    [Column(TypeName = "decimal(20, 0)")]
    public decimal? GiaBan { get; set; }

    public int? SoLuong { get; set; }

    [StringLength(30)]
    public string? Website { get; set; }

    [Column("IdLXM")]
    public Guid? IdLxm { get; set; }

    public int? TrangThai { get; set; }

    [ForeignKey("IdLxm")]
    [InverseProperty("XeMays")]
    public virtual LoaiXm? IdLxmNavigation { get; set; }
}
