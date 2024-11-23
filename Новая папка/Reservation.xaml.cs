using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace pz14
{
    /// <summary>
    /// Логика взаимодействия для Reservation.xaml
    /// </summary>
    public partial class Reservation : Window
    {
        public string Title { get; private set; }
        public Reservation(string title)
        {
            InitializeComponent();
            Title = title;
        }
        public void AcceptedToAssembly()
        {
            statusTB.Text = $"отель {Title} забронирован";
        }
        public void GetFinishedProduct()
        {
            statusTB.Text = $"Подтверждение брони отеля {Title}  отправлено на почти";
        }
    }
}
