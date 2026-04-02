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

namespace DepositCalculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double P = double.Parse(AmountTextBox.Text);
                int months = int.Parse(MonthsTextBox.Text);
                double rate = double.Parse(RateTextBox.Text) / 100;

                double result;

                if (SimpleRadio.IsChecked == true)
                {
                    result = Calculator.Simple(P, rate, months);
                }
                else
                {
                    result = Calculator.Compound(P, rate, months);
                }

                ResultText.Text = result.ToString("F2");
            }
            catch
            {
                ResultText.Text = "Ошибка!";
            }
        }
    }
}
