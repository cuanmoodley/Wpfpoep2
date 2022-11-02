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

namespace Wpfpoep2
{
    /// <summary>
    /// Interaction logic for Windowsignup.xaml
    /// </summary>
    public partial class Windowsignup : Window
    {
        public Windowsignup()
        {
            InitializeComponent();
        }
        Database1Entities db = new Database1Entities();
        public bool IsEmpty()
        {
            if (txtpassword.Text.Trim() == "" || txtusernames.Text.Trim() == " ")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

            private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            tblSignUp obj = new tblSignUp();
            if (!IsEmpty())
            {
                obj.UserName = txtusernames.Text;
                obj.Password = txtpassword.Text;
                obj.UserType = drpType.Text;

                db.tblSignUps.Add(obj);

                db.SaveChanges();

                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Empty Fields are not allowed");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow objs = new MainWindow();
            this.Hide();
            objs.Show();
        }
    }
}
