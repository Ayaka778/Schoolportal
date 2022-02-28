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

namespace Школьный_портал
{
    /// <summary>
    /// Логика взаимодействия для Администратор.xaml
    /// </summary>
    public partial class Администратор : Window
    {
        SchoolPortalEntities x = new SchoolPortalEntities();
        public Администратор()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dg.ItemsSource = x.Students.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Students tt = new Students
            {
                id_Student = Convert.ToInt32(tb13.Text),
                Key_ = tb1.Text,
                Last_name = tb2.Text,
                First_name = tb3.Text,
                Middle_name = tb4.Text,
                Class = tb5.Text,
                Number_phone = tb6.Text,
                Mail = tb7.Text,
                Street_address = tb8.Text,
                Login = tb9.Text,
                Password = tb10.Text
            };
            x.Students.Add(tt);
            x.SaveChanges();
            dg.ItemsSource = x.Students.ToList();


            MessageBox.Show("Успешное добавление");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SchoolPortalEntities x = new SchoolPortalEntities();
            int a = Convert.ToInt32(tb11.Text);

            var s = x.Students.Where(d => d.id_Student == a);
            x.Students.RemoveRange(s);
            x.SaveChanges();
            MessageBox.Show("Успешное удаление");
        }
    }
}
