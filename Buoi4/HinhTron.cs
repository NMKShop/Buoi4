using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    class HinhTron
    {
        private ToaDo tam;

        internal ToaDo Tam
        {
            get { return tam; }
            set { tam = value; }
        }


        private double bankinh;

        public double Bankinh
        {
            get { return bankinh; }
            set { bankinh = value; }
        }
        public double tinhChuvi()
        {
            return 2 * bankinh * 3.14;
        }
        public double tinhDientich()
        {
            return bankinh * bankinh * 3.14;
        }
        public HinhTron(ToaDo tam,double bankinh)
        {
            this.tam = tam;
            this.bankinh = bankinh;
        }
        public HinhTron()
        {
            tam = new ToaDo();
            bankinh = 0;
        }
        public void xuat()
        {
            Console.WriteLine("Chu vi = {0} \t Diện tích = {1}", tinhChuvi(), tinhDientich());
        }
    }
}
