using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace Tehtava3b
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private bool isUsername = false;
        private bool isPassword = false;

        public Login()
        {
            InitializeComponent();
        }

        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {
            ToggleIsUsername();
            ToggleSubmit();
        }

        private void pswPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            ToggleIsPassword();
            ToggleSubmit();
        }

        private void ToggleIsUsername()
        {
            if (txtUsername.Text.Length > 0)
                isUsername = true;
            else
                isUsername = false;
        }

        private void ToggleIsPassword()
        {
            if (pwbPassword.Password.Length > 0)
                isPassword = true;
            else
                isPassword = false;
        }

        private void ToggleSubmit()
        {
            if (isUsername && isPassword)
                btnSubmit.IsEnabled = true;
            else
                btnSubmit.IsEnabled = false;
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                string connStr = string.Format(
                    "Data source = eight.labranet.jamk.fi; database = Viini; user = {0}; password = {1}",
                    txtUsername.Text,
                    pwbPassword.Password);
                conn.ConnectionString = connStr;
                conn.Open();
                string sql = "SELECT * FROM wine";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable("Wines");
                da.Fill(dt);
                conn.Close();
                MainWindow main = new MainWindow();
                main.SetData(dt);
                main.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
