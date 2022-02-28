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
    /// Логика взаимодействия для Админвход.xaml
    /// </summary>
    public partial class Админвход : Window
    {
        SchoolPortalEntities x1 = new SchoolPortalEntities();
        public Админвход()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var a = x1.Secret_key.Single(x => x.Secret_code == tb1.Text);
                Администратор администратор = new Администратор();
                администратор.Show();
                Close();
            }
            catch
            {
                MessageBox.Show("Неправильный код");
            }
        }
    }
}
