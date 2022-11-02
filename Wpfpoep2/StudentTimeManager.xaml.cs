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
    /// Interaction logic for StudentTimeManager.xaml
    /// </summary>
    public partial class StudentTimeManager : Window
    {
        public StudentTimeManager()
        {
            InitializeComponent();
            Database1Entities db = new Database1Entities();
            var gridval = from g in db.gridstats select g;

            this.gridviews.ItemsSource = gridval.ToList();


        }
        int valone;
        int valtwo;
        int valthree;
        int valfour;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            valone = Convert.ToInt32(credits);
            valtwo = Convert.ToInt32(weekinsem);
            valthree = Convert.ToInt32(classhours);
            valfour = valone * 10 / valtwo - valthree;
            textbox1.Text = valfour.ToString(); 
            Database1Entities db = new Database1Entities();

            gridstat gridstatObject = new gridstat()
            {
                ModuleName = modulename.Text,
                ModuleCode = modulecode.Text,
                Date_Recoreded = DateTime.Now,
                Study_Hours_Remaining_For_Week = Convert.ToDecimal(textbox1),

            };
            db.gridstats.Add(gridstatObject);
            db.SaveChanges();
          
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Database1Entities db = new Database1Entities();
            this.gridviews.ItemsSource = db.gridstats.ToList();
        }
    }
}
