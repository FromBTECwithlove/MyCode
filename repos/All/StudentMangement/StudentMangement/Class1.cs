using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace StudentMangement
{
    class Student
    {
        private string hoTen;
        private string maSV;
        private int diemToan;
        private int diemVan;
        private int diemAnh;

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string MaSV { get => maSV; set => maSV = value; }
        public int DiemToan { get => diemToan; set => diemToan = value; }
        public int DiemVan { get => diemVan; set => diemVan = value; }
        public int DiemAnh { get => diemAnh; set => diemAnh = value; }

        public void NhapTT()
        {
            Console.Write("Nhap Ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap MSV: ");
            maSV = Console.ReadLine();
            Console.Write("Nhap diem Toan: ");
            do
            {
                diemToan = Convert.ToInt32(Console.ReadLine());
                if (diemToan > 10 || diemToan < 0)
                {
                    Console.WriteLine("Error! 0 < Diem Toan < 10");
                    Console.Write("Nhap lai Diem Toan:");
                }
                else break;
            } while (diemToan < 10 || diemToan > 0);

            Console.Write("Nhap diem Van : ");
            do
            {
                diemVan = Convert.ToInt32(Console.ReadLine());
                if (diemVan > 10 || diemVan < 0)
                {
                    Console.WriteLine("Error! 0 < Diem Van < 10");
                    Console.Write("Nhap lai Diem Van:");
                }
                else break;
            } while (diemVan < 10 || diemVan > 0);

            Console.Write("Nhap diem Anh : ");
            do
            {
                diemAnh = Convert.ToInt32(Console.ReadLine());
                if (diemAnh > 10 || diemAnh < 0)
                {
                    Console.WriteLine("Error! 0 < Diem Anh < 10");
                    Console.Write("Nhap lai Diem Anh:");
                }
                else break;
            } while (diemAnh < 10 || diemAnh > 0);

        }

        public void XuatTT()
        {
            Console.WriteLine("Ho Ten: {0}|| MSV: {1}|| DiemToan: {2}|| DiemVan|| {3}|| DiemAnh {4}|| DiemTB {5}", hoTen, maSV, diemToan, diemVan, diemAnh, DiemTB(diemToan, diemVan, diemAnh));
        }

        public float DiemTB(int diemtoan, int diemvan, int diemanh)
        {
            return (float)((diemtoan + diemvan + diemanh) / 3.0);
        }
    }
}
