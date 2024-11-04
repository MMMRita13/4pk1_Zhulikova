using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz14_3
{
    abstract class HotelDecorator : Hotel
    {
        protected Hotel hotel;
        public HotelDecorator(string n, Hotel hotel) : base(n)
        {
            this.hotel = hotel;
        }
    }
}
