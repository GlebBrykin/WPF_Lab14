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
using System.Collections.ObjectModel;

namespace Lab14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ObservableCollection<Product> items = new ObservableCollection<Product>();
            items.Add(
                new Product()
                {
                    Name = "Бананы",
                    Price = 100,
                    Image = "Resources/Бананы.png",
                    Category = ProductCategory.Food
                }
            );
            items.Add(
                new Product()
                {
                    Name = "Яблоки",
                    Price = 70,
                    Image = "Resources/Яблоки.jpg",
                    Category = ProductCategory.Food
                }
            );
            items.Add(
                new Product()
                {
                    Name = "Утюг",
                    Price = 3000,
                    Image = "Resources/Утюг.jpg",
                    Category = ProductCategory.Appliances
                }
            );
            items.Add(
                new Product()
                {
                    Name = "Стиральная машина",
                    Price = 30000,
                    Image = "Resources/Стиральная машина.jpg",
                    Category = ProductCategory.Appliances
                }
            );
            this.list_box.ItemsSource = items;
        }
    }
}
