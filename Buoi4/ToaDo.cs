using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi4
{
    class ToaDo
    {
        private string ten;

        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }

        
        private float x;

        public float X
        {
            get { return x; }
            set { x = value; }
        }
        float y;

        public float Y
        {
            get { return y; }
            set { y = value; }
        }
        
        public ToaDo(float x,float y)
        {
            this.x = x;
            this.y = y;
        }
        public ToaDo()
        {
            ten = "O";
            x = 0;
            y = 0;
        }
        public void nhap()
        {
            Console.Write("Tên: ");
            ten = Console.ReadLine();
            Console.Write("Tọa độ x: ");
            x = float.Parse(Console.ReadLine());
            Console.Write("Tọa độ y: ");
            y = float.Parse(Console.ReadLine());

        }
        public override string ToString()
        {
            return "Tên: " + ten + "\tTọa độ x: " + x + "\tTọa độ y: " + y;
        }


    }
}
