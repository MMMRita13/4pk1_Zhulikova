﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pz14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Facad _facade;
        public MainWindow()
        {
            InitializeComponent();
            _facade = new Facad();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
             _facade.StopProduction();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           _facade.StartProduction(hostelName.Text);
        }
    }
}
