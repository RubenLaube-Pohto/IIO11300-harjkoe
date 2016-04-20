using JAMK.ICT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Tehtava1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGet_date_Click(object sender, RoutedEventArgs e)
        {
            // Convert input string to format Xxxxx
            string name = txtName.Text.First().ToString().ToUpper() + string.Join("", txtName.Text.Skip(1)).ToLower();
            tbDate.Text = NimiPaivat.GetDate(name);
        }

        private void cdrCalendar_Date_Changed(object sender, SelectionChangedEventArgs e)
        {
            // Minus one because date arrays begin from zero
            int day = cdrCalendar.SelectedDate.Value.Day - 1;
            int month = cdrCalendar.SelectedDate.Value.Month;
            tbName.Text = NimiPaivat.HaeNimiPäivä(day, month);
        }
    }
}
