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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CursValut
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const double UsdRate = 90.0; 
        private const double EurRate = 100.0;
        private const double CnyRate = 12.5;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            if(!double.TryParse(rublesTB.Text, out double rubles))
            {
                resultTB.Text = "Ошибка: введите число";
                return;
            }

            string selectedCurency = ((ComboBoxItem)currencyCB.SelectedItem).Content.ToString();
            double result = 0;
            string currencySymbol = "";

            switch (selectedCurency)
            {
                case "USD":
                    result = rubles / UsdRate;
                    currencySymbol = "$";
                    break;

                case "EUR":
                    result = rubles / EurRate;
                    currencySymbol = "€";
                    break;
                case "CNY":
                    result = rubles / CnyRate;
                    currencySymbol = "¥";
                    break;
            }

            resultTB.Text = $"{result:F2} {currencySymbol}";
        }
    }
}
