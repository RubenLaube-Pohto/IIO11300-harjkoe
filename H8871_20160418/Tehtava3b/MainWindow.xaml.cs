using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

namespace Tehtava3b
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ICollectionView view;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void SetData(DataTable dt)
        {
            dgData.DataContext = dt;
            view = CollectionViewSource.GetDefaultView(dt);

            cbCountries.Items.Add("Kaikki");
            cbCountries.SelectedIndex = 0;
            foreach (DataRow row in dt.Rows)
            {
                if (!cbCountries.Items.Contains(row[2]))
                {
                    cbCountries.Items.Add(row[2]);
                }
            }
        }
    }
}
