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

namespace Wpfpoep2
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
        Database1Entities db = new Database1Entities();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = txtusernames.Text;
            string password = txtpassword.Text;
            var rec = db.tblSignUps.Where(a => a.UserName == username && a.Password == password).FirstOrDefault();
            if (rec != null)
            {

                StudentTimeManager win2 = new StudentTimeManager();
                this.Hide();
                win2.Show();

            }
            else
            {
                MessageBox.Show("Login Fail");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Windowsignup obj = new Windowsignup();
            this.Hide();
            obj.Show();
        }
    }
}
