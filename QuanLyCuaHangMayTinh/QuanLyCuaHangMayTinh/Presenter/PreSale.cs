﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyCuaHangMayTinh.Model;
namespace QuanLyCuaHangMayTinh.Presenter
{
    public class PreSale
    {
        Entity db= new Entity();

        public Entity Db { get => db; set => db = value; }

        prsMain prsMain = new prsMain();
        PreCustomer customers= new PreCustomer();
        preEmployee employees=new preEmployee();
        preComputer computers=new preComputer();
        private HoaDonBan Buy(DateTime ngayban, String maNV, String maKH, Double TongTien)
        {
            HoaDonBan newHoadon = new HoaDonBan();
            newHoadon.addData(ngayban,maNV, maKH, TongTien);
            Db.HoaDonBans.Add(newHoadon);
            Db.SaveChanges();
            return newHoadon;
        }
        public void AddBuyDetails(DataTable hoadon, DateTime ngayban, String maNV, String maKH, Double TongTien)
        {
            foreach (DataRow dr in hoadon.Rows)
            {
                HoaDonBan a=Buy(ngayban,maNV,maKH,TongTien);
                ChiTietHDB chitiet = new ChiTietHDB
                {
                    MaHDB = a.MaHDB,
                    MaMVT = dr["MaMVT"].ToString(),
                    Soluong = (int?)dr["SoLuong"],
                    Dongia = (double?)dr["DonGia"]
                };
                Db.ChiTietHDBs.Add(chitiet);
                Db.SaveChanges();
            }
            
        }
        
    }
}