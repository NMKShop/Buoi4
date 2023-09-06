using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding=Encoding.Unicode;
            ToaDo td = new ToaDo();
            td.nhap();
            string info = td.ToString();
            Console.WriteLine(info);
            //Hình tròn
            HinhTron hc = new HinhTron();
            hc.xuat();
            Console.ReadKey();
        }
    }
}
