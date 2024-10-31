using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz14
{
    internal class Facad
    {
        private Reservation _reservation;
        private Pay _pay;
        private Search _search;

        public void InitProduction(string title)
        {
            _search = new Search(title);
            _reservation = new Reservation(title);
            _pay = new Pay(title);
            
            _search.Show();
            _reservation.Show();
            _pay.Show();
            
        }

        public void StartProduction(string title)
        {
            InitProduction(title);
            
            _search.AcceptedToAssembly();
            _reservation.AcceptedToAssembly();
            _pay.ReadyToWork();
            
        }

        public void StopProduction()
        {
            _search.GetFinishedProduct();
            _reservation.GetFinishedProduct();
            _pay.Postponed();
            
        }
    }
}
