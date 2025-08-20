using ApplicationConstants;
using POINTOFSALE.MainWindows;
using System.Windows;

namespace POINTOFSALE
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

        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            if (UserName?.Text == "admin" && Password?.Password == "1234")
            {
                var dashboard = new Dashboard();
                dashboard.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(Constants.InvalidLoginMessage);
            }
        }
    }
}
