using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp3.DomainClass;

[Table("NhanVien")]
[Index("Ma", Name = "UQ__NhanVien__3214CC9EC1B6937A", IsUnique = true)]
public partial class NhanVien
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Ma { get; set; }

    [StringLength(30)]
    public string? Ten { get; set; }

    [StringLength(30)]
    public string? TenDem { get; set; }

    [StringLength(30)]
    public string? Ho { get; set; }

    [StringLength(10)]
    public string? GioiTinh { get; set; }

    [Column(TypeName = "date")]
    public DateTime? NgaySinh { get; set; }

    [StringLength(100)]
    public string? DiaChi { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? Sdt { get; set; }

    [Unicode(false)]
    public string? MatKhau { get; set; }

    [Column("IdCV")]
    public Guid? IdCv { get; set; }

    public int? TrangThai { get; set; }

    [ForeignKey("IdCv")]
    [InverseProperty("NhanViens")]
    public virtual ChucVu? IdCvNavigation { get; set; }
}
