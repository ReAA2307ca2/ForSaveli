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
    /// Логика взаимодействия для Reg.xaml
    /// </summary>
    public partial class Reg : Window
    {
        ApplicationContext _context;
        public Reg(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();

            cb_status.ItemsSource = Enum.GetValues(typeof(WorkStatus));
        }

        private void Button_Click_reg(object sender, RoutedEventArgs e)
        {
            User newUser = new User()
            {
                EmployeeId = tb_log.Text,
                Password = tb_pass.Text,
                WorkStatus = (WorkStatus)cb_status.SelectedItem,
                ContactInfo = new ContactInfo()
                {
                    Email = tb_mail.Text,
                    Phone = tb_phone.Text,
                    Telegram = tb_tele.Text
                }
            };
            _context.Users.Add(newUser);
            _context.SaveChanges();
            DialogResult = true;
            return;
        }

        private void Button_Click_cancel(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            return;
        }
    }
}
