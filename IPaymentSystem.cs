using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz14
{
    // 1. Интерфейс для платёжных систем
    public interface IPaymentSystem
    {
        void ProcessPayment(string hotelTitle, Pay pay);
    }

    // 2. Реализация для кредитной карты
    public class CreditCardPayment : IPaymentSystem
    {
        public void ProcessPayment(string hotelTitle, Pay pay)
        {
            pay.ReadyToWork("Кредитная карта");
            Console.WriteLine($"Платёж по кредитной карте для отеля {hotelTitle} прошёл успешно.");
        }
    }

    // 3. Реализация для электронного кошелька
    public class EWalletPayment : IPaymentSystem
    {
        public void ProcessPayment(string hotelTitle, Pay pay)
        {
            pay.ReadyToWork("Электронный кошелёк");
            Console.WriteLine($"Платёж через электронный кошелёк для отеля {hotelTitle} прошёл успешно.");
        }
    }

    // 4. Адаптер
    public class PaymentAdapter : IPaymentSystem
    {
        private readonly IPaymentSystem _paymentSystem;

        public PaymentAdapter(IPaymentSystem paymentSystem)
        {
            _paymentSystem = paymentSystem;
        }

        public void ProcessPayment(string hotelTitle, Pay pay)
        {
            _paymentSystem.ProcessPayment(hotelTitle, pay); // Вызов метода из конкретной системы
        }
    }


}
