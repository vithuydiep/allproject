using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANCUOIKI
{
    class BaoVe :Nhanvien
    {
        private string sChucVu;
        public string ChucVu
        {
            get { return this.sChucVu; }
            set { this.sChucVu = value; }
        }
        public BaoVe():base()
        {

        }
        public BaoVe(string ten, int namsinh, string ma, string dtdđ, string dtnr, string diachi, string chinhanh):base(ten, namsinh, ma, dtdđ, dtnr, diachi,chinhanh)
        {

        }
        ~BaoVe()
        {

        }
        public override void Nhap()
        {
            base.Nhap();
        }
        public override void Xuat()
        {
            this.sChucVu = "Bảo vệ";
            base.Xuat();
            Console.WriteLine("\t\t\t\tChức vụ: " + this.sChucVu);
        }

    }
}
