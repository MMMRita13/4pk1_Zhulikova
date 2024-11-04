using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz14_3
{
    class WifiHotel : HotelDecorator
    {
        public WifiHotel(Hotel h)
            : base(h.Name + ", с Wifi", h)
        { }

        public override int GetCost()
        {
            return hotel.GetCost() + 500;
        }
    }
}
