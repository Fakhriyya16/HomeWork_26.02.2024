using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_26._02._2024.Models
{
    internal class Test : Car
    {
        public int bestSpeed;
        public Test() : base(5)
        {
            bestSpeed = speed;
        }
    }
}
