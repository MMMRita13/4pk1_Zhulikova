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
        private IPaymentSystem _paymentSystem; // Интерфейс платёжной системы
        private Search _search;

        public void InitProduction(string title)
        {
            _search = new Search(title);
            _reservation = new Reservation(title);

            // В зависимости от логики, выбираем платежную систему
            // Например, для демонстрации выберем CreditCardPayment
            var paymentType = new CreditCardPayment(); // или new EWalletPayment();
            _paymentSystem = new PaymentAdapter(paymentType);

            _search.Show();
            _reservation.Show();

            // Создаём экземпляр Pay и передаём в адаптер
            Pay pay = new Pay(title);
            pay.Show();

            // Вызов адаптера для обработки платежа
            _paymentSystem.ProcessPayment(title, pay);
        }

        public void StartProduction(string title)
        {
            InitProduction(title);

            _search.AcceptedToAssembly();
            _reservation.AcceptedToAssembly();
        }

        public void StopProduction()
        {
            _search.GetFinishedProduct();
            _reservation.GetFinishedProduct();
            Console.WriteLine("Производство остановлено.");
        }
    }
}
