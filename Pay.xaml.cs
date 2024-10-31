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
    /// Логика взаимодействия для Pay.xaml
    /// </summary>
    public partial class Pay : Window
    {
        public string Title { get; private set; }
        public Pay(string title)
        {
            InitializeComponent();
            Title = title;
        }
        public void ReadyToWork()
        {
            statusTB.Text = $"Предоплата для отеля {Title} прошла";
        }
        public void Postponed()
        {
            statusTB.Text = "Чек отправлен на почту";
        }
        
    }
}
