using System;
using System.Collections.Generic;
using System.Text;

namespace Vũ_Thị_Kim_Chi_21A4040009__Chuong3_Bai6_
{
    class SinhVien
    {
        public string MaSV;
        private string HoTen;
        private int NamSinh;
        private double DiemLapTrinh;
        private double DiemCSDL;
        private double DiemTB;

        //Ham khong tham so
        public SinhVien()
        {
            MaSV = "";
            HoTen = "";
            NamSinh = 1900;
            DiemLapTrinh = DiemCSDL = DiemTB = 0;
        }

        //Ham co tham so
        public SinhVien(string HoTen, int NamSinh, double DiemLapTrinh, double DiemCSDL)
        {
            this.HoTen = HoTen;
            this.NamSinh = NamSinh;
            this.DiemLapTrinh = DiemLapTrinh;
            this.DiemCSDL = DiemCSDL;
        }

        //Nhap thong tin sinh vien
        public void nhap()
        {
            Console.WriteLine("Hay nhap ma cua sinh vien");
            MaSV = Console.ReadLine();
            Console.WriteLine("Hay nhap ho ten cua sinh vien");
            HoTen = Console.ReadLine();
            Console.WriteLine("Hay nhap nam sinh cua sinh vien");
            NamSinh = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hay nhap diem lap trinh cua sinh vien");
            DiemLapTrinh =Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hay nhap diem co so du lieu cua sinh vien");
            DiemCSDL = Convert.ToDouble(Console.ReadLine());
        }

        public void InDiemTB()
        {
            DiemTB = (DiemLapTrinh + DiemCSDL) / 2;
        }

        // In thong tin sinh vien duoc tao boi ham khong co tham so
        public void InThongTinSV()
        {
            Console.WriteLine("Thong tin cua sinh vien la: \n Ma sinh vien: {0} \t Ho ten: {1} \t Nam sinh: {2} " +
                "\n Diem lap trinh: {3} \t Diem CSDL: {4} \t Diem trung binh: {5}", MaSV, HoTen, NamSinh,
                DiemLapTrinh, DiemCSDL, DiemTB);
        }

        // In thong tin sinh vien duoc tao boi ham co tham so
        public void HienThongTin()
        {
            Console.WriteLine("Ho ten sinh vien duoc tao boi ham co tham so la: {0}", this.HoTen);
            Console.WriteLine("Nam sinh: {0}", this.NamSinh);
            Console.WriteLine("Diem lap trinh: {0}", this.DiemLapTrinh);
            Console.WriteLine("Diem CSDL: {0}", this.DiemCSDL);
        }

        public void TBtren8()
        {
            if (DiemTB > 8)
            {
                Console.WriteLine("Danh sach sinh vien co diem trung binh tren 8 la: \n Ma sinh vien: {0} " +
                "\t Ho ten: {1} \t Nam sinh: {2} \t Diem trung binh: {3}",MaSV, HoTen, NamSinh, DiemTB);
            }
        }

    }
}
