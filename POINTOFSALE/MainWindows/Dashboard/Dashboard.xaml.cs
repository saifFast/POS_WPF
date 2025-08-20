using POINTOFSALE.MainWindows.Features;
using System.Windows;

namespace POINTOFSALE.MainWindows
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var productManagement = new ProductManagement();
            productManagement.Show();
            this.Close();
        }
    }
}
