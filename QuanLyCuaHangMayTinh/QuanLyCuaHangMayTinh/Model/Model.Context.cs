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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entity : DbContext
    {
        public Entity()
            : base("name=Entity")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BanPhim> BanPhims { get; set; }
        public virtual DbSet<Chip> Chips { get; set; }
        public virtual DbSet<ChiTietHDB> ChiTietHDBs { get; set; }
        public virtual DbSet<ChiTietHDN> ChiTietHDNs { get; set; }
        public virtual DbSet<Chuot> Chuots { get; set; }
        public virtual DbSet<CoMH> CoMHs { get; set; }
        public virtual DbSet<Dungluong> Dungluongs { get; set; }
        public virtual DbSet<HangSX> HangSXes { get; set; }
        public virtual DbSet<HoaDonBan> HoaDonBans { get; set; }
        public virtual DbSet<HoaDonNhap> HoaDonNhaps { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Loa> Loas { get; set; }
        public virtual DbSet<LoaiMay> LoaiMays { get; set; }
        public virtual DbSet<ManHinh> ManHinhs { get; set; }
        public virtual DbSet<MayVT> MayVTs { get; set; }
        public virtual DbSet<NhaCC> NhaCCs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<OCD> OCDs { get; set; }
        public virtual DbSet<OCung> OCungs { get; set; }
        public virtual DbSet<Ram> Rams { get; set; }
        public virtual DbSet<TocDo> TocDoes { get; set; }
        public virtual DbSet<USB> USBs { get; set; }
    }
}