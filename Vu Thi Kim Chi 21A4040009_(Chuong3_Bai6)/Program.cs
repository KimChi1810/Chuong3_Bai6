using System;

namespace Vũ_Thị_Kim_Chi_21A4040009__Chuong3_Bai6_
{
    class Program
    {
        static void Main(string[] args)
        { 

            SinhVien SV = new SinhVien();
            SV.nhap();
            SV.InDiemTB();
            SV.InThongTinSV();
            SV.HienThongTin();
            Console.ReadLine();

            DanhSach DS = new DanhSach();
            DS.nhapDS();
            DS.xuatDSdiemTB();
            DS.xuatDS();
            DS.DSSVTBtren8();
            Console.WriteLine("Danh sach sinh vien duoc sap xep theo ma sinh vien");
            DS.SapXep();
            DS.xuatDS();
            Console.ReadLine();

        }

    }
}
