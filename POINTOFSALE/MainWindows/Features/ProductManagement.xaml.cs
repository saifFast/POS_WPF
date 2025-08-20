using Models;
using System.Collections.ObjectModel;
using System.Windows;

namespace POINTOFSALE.MainWindows.Features
{
    public partial class ProductManagement : Window
    {
        public ObservableCollection<Product> Products { get; set; }

        public ProductManagement()
        {
            InitializeComponent();

            // Initialize sample data
            Products = new ObservableCollection<Product>
            {
                new Product { Id = 1, Name = "Product A", Description = "Description A", CategoryId = 101 },
                new Product { Id = 2, Name = "Product B", Description = "Description B", CategoryId = 102 },
                new Product { Id = 3, Name = "Product C", Description = "Description C", CategoryId = 103 }
            };

            // Bind the DataGrid to the Products collection
            ProductsDataGrid.ItemsSource = Products;
        }

        private void ListProducts_Click(object sender, RoutedEventArgs e)
        {
            // Toggle the visibility of the DataGrid
            if (ProductsDataGrid.Visibility == Visibility.Collapsed)
            {
                ProductsDataGrid.Visibility = Visibility.Visible;
            }
            else
            {
                ProductsDataGrid.Visibility = Visibility.Collapsed;
            }
        }
    }    
}
