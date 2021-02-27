using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANCUOIKI
{
    class Nhanvien:DienThoai
    {
        protected string sChinhanh;
        public string Chinhanh
        {
            get { return this.sChinhanh; }
            set { this.sChinhanh = value; }
        }
      
        public Nhanvien() : base()
        {

        }

        public Nhanvien(string ten, int namsinh,string ma, string dtdđ, string dtnr, string diachi, string chinhanh) : base(ten,namsinh, ma, dtdđ, dtnr, diachi)
        {
            this.sChinhanh = chinhanh;
          
        }
        ~Nhanvien()
        {

        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap ten chi nhanh: ");
            this.sChinhanh = Console.ReadLine();
          

        }
        public void Nhap(string ten, string ma, string dtdđ, string chinhanh)
        {
            base.Nhap(ten, ma, dtdđ);
            this.sChinhanh = chinhanh;
           
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("\t\t\t\tLàm việc tại chi nhánh : " + this.sChinhanh);
            
        }
        public override void update()
        {
            base.update();
            Console.Write("Nhap ten chi nhanh: ");
            this.sChinhanh = Console.ReadLine();
           
        }
        
    }
}
