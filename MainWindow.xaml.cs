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

namespace Bai12_Phieu1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Controller controller = new Controller();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text.ToString();
            string password = txtPassword.Password.ToString();

            var user = controller.login("mynamebvh", "hoangdz");


            if (user != null)
            {
                Window2 window2 = new Window2();
                window2.Tag = user;
                window2.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai");
            }    
        }
    }
}
