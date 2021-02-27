using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOANCUOIKI
{   
    
    class KHTuVan : DienThoai
    {
        private List<DateTime> dTime;
        public List<DateTime> Time
        {
            get { return this.dTime; }
            set { this.dTime = value; }
        }
        public KHTuVan() : base()
        {
            dTime = new List<DateTime>();
        }

        public KHTuVan(string ten, int namsinh, string ma, string dtdđ, string dtnr, string diachi, List<DateTime> time) : base(ten,namsinh, ma, dtdđ, dtnr, diachi)
        {
            this.dTime = time;
        }
        ~KHTuVan()
        {

        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhập số lần tư vấn");
            int count = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<count;i++)
            {
                DateTime t = new DateTime();
                Console.Write("Nhập thời gian giao dịch: ");
                t = DateTime.Parse(Console.ReadLine());
                this.dTime.Add(t);
            }

        }

        public override void Xuat()
        {
            base.Xuat();
            Console.Write("\t\t\t\tThời gian đã liên hệ :  ");
            for (int i = 0; i < this.dTime.Count; i++)
            {
                  Console.Write( this.dTime[i].ToString("dd/MM/yyyy HH:mm:ss")+"\n\t\t\t\t\t\t\t");
               
            }
        }
        public override void update()
        {
            base.update();
            Console.WriteLine("Nhập số lần tư vấn");
            int count = Convert.ToInt32(Console.ReadLine());
            this.dTime.Clear();
            for (int i = 0; i < count; i++)
            {
                DateTime t = new DateTime();
                Console.Write("Nhập thời gian giao dịch: ");
                t = DateTime.Parse(Console.ReadLine());
                this.dTime.Add(t);
            }

        }
        public override void edittime()
        {
            DateTime t = new DateTime();
            Console.Write("Nhập thời gian giao dịch: ");
            t = DateTime.Parse(Console.ReadLine());
            this.dTime.Add(t);
        }
    }
}
