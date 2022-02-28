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

namespace Школьный_портал
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SchoolPortalEntities x1 = new SchoolPortalEntities();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (cb1.Text == "Ученик")
                {
                    var a = x1.Students.Single(x => x.Login == tb1.Text && x.Password == tb2.Text);
                    if (a.Login == tb1.Text && a.Password == tb2.Text)
                    {
                        App.Current.Resources["id"] = a.id_Student;
                        Школьник школьник = new Школьник();
                        школьник.Show();
                        MessageBox.Show("Вы вошли как Ученик");
                    }



                }
                else
                {
                    var aa = x1.Teachers.Single(x => x.Login == tb1.Text && x.Password == tb2.Text);
                    if (aa.Login == tb1.Text && aa.Password == tb2.Text)
                    {
                        App.Current.Resources["id"] = aa.id_Teacher;
                        Учитель1 учитель = new Учитель1();
                        учитель.Show();
                        MessageBox.Show("Вы вошли как Учитель");
                    }

                }

            }
            catch
            {
               MessageBox.Show("Ошибка в заполнении данных");
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Админвход админвход = new Админвход();
            админвход.Show();
            Close();
        }



    }
}
