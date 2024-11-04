using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz14_3
{
    class OrenHotel : Hotel
    {
        public OrenHotel() : base("Оренбургский отель")
        { }
        public override int GetCost()
        {
            return 2500;
        }
    }
    class MoscowHotel : Hotel
    {
        public MoscowHotel() : base("Московский отель")
        { }
        public override int GetCost()
        {
            return 5000;
        }
    }
}
