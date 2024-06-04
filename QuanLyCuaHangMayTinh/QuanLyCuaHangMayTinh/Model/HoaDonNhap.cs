﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyCuaHangMayTinh.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;

    public partial class HoaDonNhap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HoaDonNhap()
        {
            this.ChiTietHDNs = new HashSet<ChiTietHDN>();
        }
        public string autoGenCode()
        {
            using (var context = new Entity())
            {
                var lastQuery = context.HoaDonNhaps.OrderByDescending(p => p.MaHDN).FirstOrDefault();
                MaHDN = lastQuery.MaHDN;

                if (lastQuery != null)
                {
                    // Xử lý lastQuery
                    int temp = Convert.ToInt32(MaHDN.Substring(3)) + 1;
                    string code = "";
                    if (temp < 10)
                    {
                        code = "0" + temp.ToString();
                    }
                    string newcode = "HDN" + code;
                    return newcode;
                }
                else
                {
                    MessageBox.Show("Cơ sở dữ liệu chưa có dữ liệu", "Lỗi tìm kiếm", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    return "HDN0";
                }
            }
        }
        public void addData(DateTime ngayban, String maNV, String maNCC, Double TongTien)
        {
            using (var db = new Entity())
            {
                HoaDonNhap HoaDonNhap = new HoaDonNhap() { MaHDN = autoGenCode(), NgayNhap = ngayban, MaNV = maNV, MaNCC = maNCC, ThanhTien = TongTien };
                db.HoaDonNhaps.Add(HoaDonNhap);
                db.SaveChanges();
            }
        }

        public string MaHDN { get; set; }
        public Nullable<System.DateTime> NgayNhap { get; set; }
        public string MaNV { get; set; }
        public string MaNCC { get; set; }
        public Nullable<double> ThanhTien { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHDN> ChiTietHDNs { get; set; }
        public virtual NhaCC NhaCC { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
