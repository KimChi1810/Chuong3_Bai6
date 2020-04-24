using System;
using System.Collections.Generic;
using System.Text;

namespace Vũ_Thị_Kim_Chi_21A4040009__Chuong3_Bai6_
{
    class DanhSach
    {
        private int n;
        private SinhVien[] DS;
       

        //Nhap danh sach sinh vien
        public void nhapDS()
        {
            Console.WriteLine("Hay nhap so luong sinh vien");
            n = Convert.ToInt32(Console.ReadLine());
            DS = new SinhVien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Hay nhap thong tinh sinh vien thu {0}", i );
                DS[i] = new SinhVien();
                DS[i].nhap();
            }
        }

       public void xuatDSdiemTB()
        {
            for (int i = 0; i < n; i++)
            {
                DS[i].InDiemTB();
            }
        }

        //In thong tin sinh vien trong danh sach
        public void xuatDS()
        {
            if (DS != null && n > 0) ;
            Console.WriteLine("Danh sach sinh vien");
            for(int i =0;i<n;i++)
            {
                DS[i].InThongTinSV();
            }
        }

        //In danh sach sinh vien co DiemTB >8
        public void DSSVTBtren8()
        {
            for (int i = 0; i < n; i++)
            {
                DS[i].TBtren8();
            }
        }

        //Sap xep danh sach theo MaSV tang dan
        public void SapXep()
        {
            for (int i = 0; i < n - 1 ; i++)
            {
                for(int j = i + 1; j < n; j++)
                {
                    if(string.Compare(DS[i].MaSV,DS[j].MaSV,true) >0)
                    {
                        SinhVien tg = new SinhVien();
                        tg = DS[i];
                        DS[i] = DS[j];
                        DS[j] = tg;
                    }
                }
            }
        }
    }
}
