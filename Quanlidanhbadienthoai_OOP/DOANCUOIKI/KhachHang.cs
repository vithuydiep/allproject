using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANCUOIKI
{
    class KhachHang : DienThoai
    {
        private int isolangiaodich;
        public int solangiaodich
        {
            get { return this.isolangiaodich; }
            set { this.isolangiaodich = value; }
        }
        public KhachHang() : base()
        {

        }

        public KhachHang(string ten, int namsinh,string ma, string dtdđ, string dtnr, string diachi, int sogd) : base(ten,namsinh, ma, dtdđ, dtnr, diachi)
        {
            this.isolangiaodich = sogd;
        }
        ~KhachHang()
        {

        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap so lan giao dich: ");
            this.isolangiaodich = Convert.ToInt32(Console.ReadLine());

        }
        public void Nhap(string ten,string ma, string dtdđ,int sogd)
        {
            base.Nhap(ten, ma, dtdđ);
            this.isolangiaodich = sogd;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("\t\t\t\tSố lần giao dịch : " + this.isolangiaodich);
        }
        public override void update()
        {
            base.update();
            Console.Write("Nhap so lan giao dich: ");
            this.isolangiaodich = Convert.ToInt32(Console.ReadLine());
        }
        public static bool operator >(KhachHang a, KhachHang b)
        {
            return a.isolangiaodich > b.isolangiaodich;
        }
        public static bool operator <(KhachHang a, KhachHang b)
        {
            return a.isolangiaodich < b.isolangiaodich;

        }
        public static bool operator ==(KhachHang a, KhachHang b)
        {
            return a.isolangiaodich == b.isolangiaodich;

        }
        public static bool operator !=(KhachHang a, KhachHang b)
        {
            return a.isolangiaodich != b.isolangiaodich;

        }

    }
}
