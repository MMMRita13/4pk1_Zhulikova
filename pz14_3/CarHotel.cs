using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz14_3
{
    class CarHotel : HotelDecorator
    {
        public CarHotel(Hotel h) : base(h.Name + ", с парковкой", h)
        { }

        public override int GetCost()
        {
            return hotel.GetCost() + 800;
        }
    }
}
