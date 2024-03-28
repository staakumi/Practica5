using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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

using Practica5.Coffee_House_Cosy_CoffeeDataSetTableAdapters;
namespace Practica5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MenuTableAdapter menu = new MenuTableAdapter();
        OrdersTableAdapter orders = new OrdersTableAdapter();
        Menu_OrdersTableAdapter menu_orders = new Menu_OrdersTableAdapter();
        EmployeeTableAdapter employee = new EmployeeTableAdapter();
        FeedbackTableAdapter feedback = new FeedbackTableAdapter();
        RatingsTableAdapter rating = new RatingsTableAdapter();
        AvailableTableAdapter available = new AvailableTableAdapter();
        Payment_MethodsTableAdapter payment = new Payment_MethodsTableAdapter();
        PositionTableAdapter position = new PositionTableAdapter();
        CategoryTableAdapter category = new CategoryTableAdapter();

        public MainWindow()
        {
            InitializeComponent();
           
        }
        


       

        private void AutorisationClick(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
        }
    }
}
