using System;
using System.Collections.Generic;
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
using System.Xml;

namespace Tehtava2
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

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnGet_CSV_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dgData.DataContext = ClientService.ReadFile(txtCSV_file.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_XML_Click(object sender, RoutedEventArgs e)
        {
            if (dgData.SelectedItems.Count > 0)
            {
                try
                {
                    using (XmlWriter writer = XmlWriter.Create(txtXML_file.Text))
                    {
                        writer.WriteStartDocument();
                        writer.WriteStartElement("asiakkaat");
                        foreach (Client client in dgData.SelectedItems)
                        {
                            writer.WriteStartElement("asiakas");
                            writer.WriteElementString("nimi", client.Name);
                            writer.WriteElementString("yhteyshenkilo", client.Contact);
                            writer.WriteElementString("katuosoite", client.Address);
                            writer.WriteElementString("postinumero", client.PostalCode);
                            writer.WriteElementString("postitoimipaikka", client.City);
                            writer.WriteElementString("myynti", client.Sales);
                            writer.WriteEndElement();
                        }
                        writer.WriteEndElement();
                        writer.WriteEndDocument();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
