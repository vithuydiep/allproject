using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANCUOIKI
{
    class Quanli
    {
        private List<DienThoai> lDSĐT { get; set; }
        private List<KhachHang> lKhachHang;

        public List<KhachHang> KhachHang
        {
            get { return this.lKhachHang; }
            set { this.lKhachHang = value; }
        }
        public Quanli()
        {
            this.lDSĐT = new List<DienThoai>();
            this.lKhachHang = new List<KhachHang>();
        }
        public Quanli(List<DienThoai> dsđt, List<KhachHang> dskh)
        {
            this.lDSĐT = dsđt;
            this.lKhachHang = dskh;
        }
        public void Nhap()
        {
            Console.WriteLine("Nhập số lượng nhân viên bảo vệ: ");
            int sbv = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sbv; i++)
            {
                DienThoai dt = new BaoVe();
                dt.Nhap();
                this.lDSĐT.Add(dt);
            }

            Console.WriteLine("Nhập số lượng nhân viên kế toán: ");
            int skt = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sbv; i++)
            {
                DienThoai dt = new ThuNgan();
                dt.Nhap();
                this.lDSĐT.Add(dt);
            }

            Console.WriteLine("Nhập số lượng khách hàng : ");
            int skh = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < skh; i++)
            {
                DienThoai kh = new KhachHang();
                kh.Nhap();
                this.lDSĐT.Add(kh);
            }
            Console.WriteLine("Nhập số điện thoại tư vấn: ");
            int stv = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < stv; i++)
            {
                DienThoai tv = new KHTuVan();
                tv.Nhap();
                this.lDSĐT.Add(tv);
            }
        }
        public void Nhap(List<DienThoai> dsđt)
        {
            this.lDSĐT = dsđt;
        }
        public void Xuat()
        {
            Console.WriteLine("\t\t\t\t            DANH SÁCH DANH BẠ            ");
            for (int i = 0; i < this.lDSĐT.Count; i++)
            {
                this.lDSĐT[i].Xuat();
                Console.WriteLine();
            }
        }
        public void Search(string sdt)
        {
            int i;
            for (i = 0; i < this.lDSĐT.Count; i++)
            {
                if (this.lDSĐT[i].DTDĐ == sdt)
                {
                    this.lDSĐT[i].Xuat();
                    break;
                }
            }
            if (i >= this.lDSĐT.Count)
            {
                Console.WriteLine("Không tồn tại số điện thoại này!");

            }
        }
        public void Addnvbv()
        {
            DienThoai nv = new BaoVe();
            nv.Nhap();     
            this.lDSĐT.Add(nv);

        }
        public void Addnvtn()
        {
            DienThoai nv = new ThuNgan();
            nv.Nhap();
            this.lDSĐT.Add(nv);

        }
        public void Addkh()
        {
            DienThoai kh = new KhachHang();
            kh.Nhap();
            KhachHang kh1 = (KhachHang)kh;
            this.lKhachHang.Add(kh1);
            this.lDSĐT.Add(kh);
        }
        public void Addtv()
        {

            DienThoai tv = new KHTuVan();
            tv.Nhap();
            this.lDSĐT.Add(tv);
        }
        public void Delete(string sdt)
        {

            for (int i = 0; i < this.lDSĐT.Count; i++)
                if (this.lDSĐT[i].DTDĐ == sdt)
                    this.lDSĐT.Remove(this.lDSĐT[i]);
        }
        public void Sort()
        {
            for (int i = 0; i < this.lDSĐT.Count; i++)
            {
                for (int j = i + 1; j < this.lDSĐT.Count; j++)
                {
                    if (this.lDSĐT[i] > this.lDSĐT[j])
                    {
                        DienThoai temp = this.lDSĐT[i];
                        this.lDSĐT[i] = this.lDSĐT[j];
                        this.lDSĐT[j] = temp;
                    }

                }
            }
        }
        public void discount1()
        {
            for (int i = 0; i < this.lKhachHang.Count; i++)
            {
                if (this.lKhachHang[i].solangiaodich > 10)
                {
                    Console.WriteLine("\t\t\tThuê bao " + this.lKhachHang[i].Ten + " được tặng 100k");
                   
                    this.lKhachHang[i].solangiaodich -= 10;
                }
            }
        }
        public void Sortgd()
        {
            for (int i = 0; i < this.lKhachHang.Count; i++)
            {
                for (int j = i + 1; j < this.lKhachHang.Count; j++)
                {
                    if (this.lKhachHang[i] > this.lKhachHang[j])
                    {
                        KhachHang temp = this.lKhachHang[i];
                        this.lKhachHang[i] = this.lKhachHang[j];
                        this.lKhachHang[j] = temp;
                    }
                }
            }
        }
        public void Xuatkh()
        {
            Console.WriteLine("\t\t\t\t            DANH SÁCH KHÁCH HÀNG            ");
            for(int i=0;i<this.lKhachHang.Count;i++)
            {
                this.lKhachHang[i].Xuat();

            }
        }
        public void First()
        {
            Sortgd();
            this.lKhachHang[this.KhachHang.Count-1].Xuat();
        }
    }
}

