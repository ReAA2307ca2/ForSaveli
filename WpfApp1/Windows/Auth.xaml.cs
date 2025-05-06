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
using WpfApp1.Data;
using WpfApp1.Model;

namespace WpfApp1.Windows
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Window
    {
        private ApplicationContext _context;
        public Auth(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tb_log.Text) && string.IsNullOrWhiteSpace(tb_pass.Text))
            {
                User loginUser = _context.Users.FirstOrDefault(q => q.EmployeeId == tb_log.Text 
                && q.Password == tb_pass.Text);
                if(loginUser != null)
                {
                    DialogResult = true;
                    return;
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Reg reg = new(_context);
            reg.ShowDialog();
            //aboba
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            return;
        }
    }
}
