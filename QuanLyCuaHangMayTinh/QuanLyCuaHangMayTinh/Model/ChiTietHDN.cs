//------------------------------------------------------------------------------
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
    
    public partial class ChiTietHDN
    {
        public string MaHDN { get; set; }
        public string MaMVT { get; set; }
        public Nullable<int> Soluong { get; set; }
        public Nullable<double> Dongia { get; set; }
        public Nullable<double> Thanhtien { get; set; }
    
        public virtual HoaDonNhap HoaDonNhap { get; set; }
        public virtual MayVT MayVT { get; set; }
    }
}
