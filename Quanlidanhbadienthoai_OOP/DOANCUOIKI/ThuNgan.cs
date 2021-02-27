using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANCUOIKI
{
    class ThuNgan : Nhanvien
    {
        private string sChucVu;
        public string ChucVu
        {
            get { return this.sChucVu; }
            set { this.sChucVu = value; }
        }
        public ThuNgan():base()
        {

        }
        public ThuNgan(string ten, int namsinh, string ma, string dtdđ, string dtnr, string diachi, string chinhanh):base(ten, namsinh, ma, dtdđ, dtnr, diachi,chinhanh)
        {
         
        }
        ~ThuNgan()
        {

        }
        public override void Nhap()
        {
            base.Nhap();
        }
        public override void Xuat()
        {
            this.sChucVu = "Thu Ngân";
            base.Xuat();
            Console.WriteLine("\t\t\t\tChức vụ: " + this.sChucVu);
        }

    }
}
