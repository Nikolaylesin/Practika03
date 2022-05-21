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

namespace WorkWithSubscribers
{
    /// <summary>
    /// Логика взаимодействия для Billing.xaml
    /// </summary>
    public partial class Billing : Page
    {
        public Billing()
        {
            InitializeComponent();
            DGridTariff.ItemsSource = TeleconNevaEntities.GetContext().Тарифы2_.ToList();
            DGridPayment.ItemsSource = TeleconNevaEntities.GetContext().Payments.ToList();
        }

        private void Otchet_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Отчет свормирован");
        }
    }
}
