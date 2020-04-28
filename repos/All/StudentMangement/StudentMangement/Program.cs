using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMangement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<SinhVien> ListSinhVien = new List<SinhVien>();
            int n;
            Console.Write("Nhap so SV: ");
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0)
                {
                    Console.WriteLine("Error! So SV phai lon hon 0!");
                    Console.Write("Nhap lai so SV:");
                }
                else break;
            } while (n > 0);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin sinh vien thu {0}", (i + 1));
                SinhVien sv = new SinhVien();
                sv.NhapTT();
                ListSinhVien.Add(sv);
                Console.WriteLine("--------------------------------------");
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Thong tin sinh vien thu {0}", (i + 1));
                ListSinhVien[i].XuatTT();
                Console.WriteLine("--------------------------------------");
            }
            // ListSinhVien[i].DiemTB(ListSinhVien[i].DiemToan, ListSinhVien[i].DiemVan, ListSinhVien[i].DiemAnh);
            SinhVien tmp;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (ListSinhVien[j].DiemTB(ListSinhVien[j].DiemToan, ListSinhVien[j].DiemVan, ListSinhVien[j].DiemAnh) < ListSinhVien[i].DiemTB(ListSinhVien[i].DiemToan, ListSinhVien[i].DiemVan, ListSinhVien[i].DiemAnh))
                    {
                        //cach trao doi gia tri
                        tmp = ListSinhVien[i];
                        ListSinhVien[i] = ListSinhVien[j];
                        ListSinhVien[j] = tmp;
                    }
                }
            }
            Console.WriteLine("Sap Xep Theo thu tu tang dan");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("STT {0}||Ten: {1}||Diem TB: {2}", (i + 1), ListSinhVien[i].HoTen, ListSinhVien[i].DiemTB(ListSinhVien[i].DiemToan, ListSinhVien[i].DiemVan, ListSinhVien[i].DiemAnh));
            }
            Console.ReadKey();
        }
    }
}
