using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANCUOIKI
{
    class DienThoai:IDienThoai
    {
        protected string sTen;
        protected int iNamsinh;
        protected string sMa;
        protected string sDTDĐ;
        protected string sDTNR;
        protected string sDiachi;

        public string Ten
        {
            get { return this.sTen; }
            set { this.sTen = value; }
        }
        public int Namsinh
        {
            get { return this.iNamsinh; }
            set
            {
                this.iNamsinh = value;
            }
        }
        public string Ma
        {
            get { return this.sMa; }
            set { this.sMa = value; }
        }

        public string DTDĐ
        {
            get { return this.sDTDĐ; }
            set { this.sDTDĐ = value;}
        }
        public string DTNR
        {
            get { return this.sDTNR; }
            set { this.sDTNR = value; }
        }
        public string Diachi
        {
            get { return this.sDiachi; }
            set { this.sDiachi = value; }
        }

         public DienThoai()
        {

        }
        public DienThoai(string Ten,int Namsinh, string Ma, string DTDĐ, string DTNR, string Diachi)
        {
            this.sTen = Ten;
            this.iNamsinh = Namsinh;
            this.sMa = Ma;
            this.sDTDĐ = DTDĐ;
            this.sDTNR = DTNR;
            this.sDiachi = Diachi;
        }
        public DienThoai(string Ten,string Ma,string DTDĐ)
        {
            this.sTen = Ten;
            this.sMa = Ma;
            this.sDTDĐ = DTDĐ;
        }
        public DienThoai(string Ten)
        {
            this.sTen = Ten;
        }
        ~DienThoai()
        {

        }

        public virtual void Nhap()
        {
            Console.Write("\t\t\t\tNhap ho ten chu sđt: ");
            this.sTen = Console.ReadLine();
            Console.Write("\t\t\t\tNhap nam sinh: ");
            this.iNamsinh = Convert.ToInt32(Console.ReadLine());
            Console.Write("\t\t\t\tNhap ma cua sđt: ");
            this.sMa = Console.ReadLine();
            Console.Write("\t\t\t\tNhap so dien thoai: ");
            this.sDTDĐ = Console.ReadLine();
            Console.Write("\t\t\t\tNhap so dien thoai nha: ");
            this.sDTNR = Console.ReadLine();
            Console.Write("\t\t\t\tNhap so dia chi: ");
            this.sDiachi = Console.ReadLine();
        }
        public void Nhap(string Ten,int Namsinh, string Ma, string DTDĐ, string DTNR, string Diachi)
        {
            this.sTen = Ten;
            this.iNamsinh = Namsinh;
            this.sMa = Ma;
            this.sDTDĐ = DTDĐ;
            this.sDTNR = DTNR;
            this.sDiachi = Diachi;
        }
        public void Nhap(string Ten, string Ma, string DTDĐ)
        {
            this.sTen = Ten;
            this.sMa = Ma;
            this.sDTDĐ = DTDĐ;
        }
        public void Nhap(string Ten)
        {
            this.sTen = Ten;
        }

        public virtual void Xuat()
        {
            Console.WriteLine("\t\t\t\tHọ tên  : " + this.sTen);
            Console.WriteLine("\t\t\t\tNăm sinh: " + this.iNamsinh);
            Console.WriteLine("\t\t\t\tMa số   : " + this.sMa);
            Console.WriteLine("\t\t\t\tSố DTDĐ : " + this.sDTDĐ);
            Console.WriteLine("\t\t\t\tSố DTNR : " + this.sDTNR);
            Console.WriteLine("\t\t\t\tĐịa chi : " + this.sDiachi);
        }
        public void editsđt()
        {
            Console.Write("Nhap lại số điện thoại: ");
            this.sDTDĐ = Console.ReadLine();
        }
        public void editđc()
        {
            Console.Write("Nhap lại địa chỉ: ");
            this.sDiachi = Console.ReadLine();
        }
        public virtual void edittime()
        {
           
        }
        public virtual void update()
        {
            Console.Write("Nhập số điện thoại : ");
            this.sDTDĐ = Console.ReadLine();
            Console.Write("Nhập số điện thoại nhà : ");
            this.sDTNR = Console.ReadLine();
            Console.Write("Nhập địa chỉ : ");
            this.sDiachi = Console.ReadLine();
        }
        public static bool operator >(DienThoai a, DienThoai b)
        {
            return a.Namsinh < b.Namsinh;
        }
        public static bool operator <(DienThoai a, DienThoai b)
        {
            return a.Namsinh > b.Namsinh;
        }
        public static bool operator ==(DienThoai a, DienThoai b)
        {
            return a.Namsinh == b.Namsinh;
        }
        public static bool operator !=(DienThoai a, DienThoai b)
        {
            return a.Namsinh != b.Namsinh;
        }

    }
}
