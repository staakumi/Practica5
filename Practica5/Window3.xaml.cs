using Practica5.Coffee_House_Cosy_CoffeeDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
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

namespace Practica5
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
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

        public Window3()
        {
            InitializeComponent();
            MenuDataGrid.ItemsSource = menu.GetData();
            OrdersDataGrid.ItemsSource = orders.GetData();
            MenuOrdersDataGrid.ItemsSource = menu_orders.GetData();
            EmployeeDataGrid.ItemsSource = employee.GetData();
            FeedbackDataGrid.ItemsSource = feedback.GetData();
            RatingsDataGrid.ItemsSource = rating.GetData();
            AvailableDataGrid.ItemsSource = available.GetData();
            PaymentMethodsDataGrid.ItemsSource = payment.GetData();
            PositionDataGrid.ItemsSource = position.GetData();
            CategoryDataGrid.ItemsSource = category.GetData();

        }
        public void ShowMenuClick(object sender, EventArgs e)
        {

            MenuDataGrid.Visibility = Visibility.Visible;
            OrdersDataGrid.Visibility = Visibility.Collapsed;
            MenuOrdersDataGrid.Visibility = Visibility.Collapsed;
            EmployeeDataGrid.Visibility = Visibility.Collapsed;
            FeedbackDataGrid.Visibility = Visibility.Collapsed;
            RatingsDataGrid.Visibility = Visibility.Collapsed;
            AvailableDataGrid.Visibility = Visibility.Collapsed;
            PaymentMethodsDataGrid.Visibility = Visibility.Collapsed;
            PositionDataGrid.Visibility = Visibility.Collapsed;
            CategoryDataGrid.Visibility = Visibility.Collapsed;


            Tbx1.Visibility = Visibility.Visible;
            Tbx2.Visibility = Visibility.Visible;
            Tbx3.Visibility = Visibility.Visible;
            Tbx4.Visibility = Visibility.Visible;
            Tbx5.Visibility = Visibility.Visible;

            Tbx6.Visibility = Visibility.Collapsed;
            Tbx7.Visibility = Visibility.Collapsed;
        }
        public void ShowOrdersClick(object sender, EventArgs e)
        {
            MenuDataGrid.Visibility = Visibility.Collapsed;
            OrdersDataGrid.Visibility = Visibility.Visible;
            MenuOrdersDataGrid.Visibility = Visibility.Collapsed;
            EmployeeDataGrid.Visibility = Visibility.Collapsed;
            FeedbackDataGrid.Visibility = Visibility.Collapsed;
            RatingsDataGrid.Visibility = Visibility.Collapsed;
            AvailableDataGrid.Visibility = Visibility.Collapsed;
            PaymentMethodsDataGrid.Visibility = Visibility.Collapsed;
            PositionDataGrid.Visibility = Visibility.Collapsed;
            CategoryDataGrid.Visibility = Visibility.Collapsed;

            Tbx1.Visibility = Visibility.Visible;
            Tbx2.Visibility = Visibility.Visible;
            Tbx3.Visibility = Visibility.Visible;
            Tbx4.Visibility = Visibility.Visible;
            Tbx5.Visibility = Visibility.Visible;

            Tbx6.Visibility = Visibility.Collapsed;
            Tbx7.Visibility = Visibility.Collapsed;
        }

        public void ShowMenuOrdersClick(object sender, EventArgs e)
        {
            MenuDataGrid.Visibility = Visibility.Collapsed;
            OrdersDataGrid.Visibility = Visibility.Collapsed;
            MenuOrdersDataGrid.Visibility = Visibility.Visible;
            EmployeeDataGrid.Visibility = Visibility.Collapsed;
            FeedbackDataGrid.Visibility = Visibility.Collapsed;
            RatingsDataGrid.Visibility = Visibility.Collapsed;
            AvailableDataGrid.Visibility = Visibility.Collapsed;
            PaymentMethodsDataGrid.Visibility = Visibility.Collapsed;
            PositionDataGrid.Visibility = Visibility.Collapsed;
            CategoryDataGrid.Visibility = Visibility.Collapsed;

            Tbx1.Visibility = Visibility.Visible;
            Tbx2.Visibility = Visibility.Visible;


            Tbx3.Visibility = Visibility.Collapsed;
            Tbx4.Visibility = Visibility.Collapsed;
            Tbx5.Visibility = Visibility.Collapsed;
            Tbx6.Visibility = Visibility.Collapsed;
            Tbx7.Visibility = Visibility.Collapsed;
        }

        public void ShowEmployeeClick(object sender, EventArgs e)
        {
            MenuDataGrid.Visibility = Visibility.Collapsed;
            OrdersDataGrid.Visibility = Visibility.Collapsed;
            MenuOrdersDataGrid.Visibility = Visibility.Collapsed;
            EmployeeDataGrid.Visibility = Visibility.Visible;
            FeedbackDataGrid.Visibility = Visibility.Collapsed;
            RatingsDataGrid.Visibility = Visibility.Collapsed;
            AvailableDataGrid.Visibility = Visibility.Collapsed;
            PaymentMethodsDataGrid.Visibility = Visibility.Collapsed;
            PositionDataGrid.Visibility = Visibility.Collapsed;
            CategoryDataGrid.Visibility = Visibility.Collapsed;


            Tbx1.Visibility = Visibility.Visible;
            Tbx2.Visibility = Visibility.Visible;
            Tbx3.Visibility = Visibility.Visible;
            Tbx4.Visibility = Visibility.Visible;
            Tbx5.Visibility = Visibility.Visible;
            Tbx6.Visibility = Visibility.Visible;
            Tbx7.Visibility = Visibility.Collapsed;

            Password.Visibility = Visibility.Visible;
            

            
        }
        public void ShowFeedbackClick(object sender, EventArgs e)
        {
            MenuDataGrid.Visibility = Visibility.Collapsed;
            OrdersDataGrid.Visibility = Visibility.Collapsed;
            MenuOrdersDataGrid.Visibility = Visibility.Collapsed;
            EmployeeDataGrid.Visibility = Visibility.Collapsed;
            FeedbackDataGrid.Visibility = Visibility.Visible;
            RatingsDataGrid.Visibility = Visibility.Collapsed;
            AvailableDataGrid.Visibility = Visibility.Collapsed;
            PaymentMethodsDataGrid.Visibility = Visibility.Collapsed;
            PositionDataGrid.Visibility = Visibility.Collapsed;
            CategoryDataGrid.Visibility = Visibility.Collapsed;

            Tbx1.Visibility = Visibility.Visible;
            Tbx2.Visibility = Visibility.Visible;
            Tbx3.Visibility = Visibility.Visible;

            Tbx4.Visibility = Visibility.Collapsed;
            Tbx5.Visibility = Visibility.Collapsed;
            Tbx6.Visibility = Visibility.Collapsed;
            Tbx7.Visibility = Visibility.Collapsed;

        }
        public void ShowRatingsClick(object sender, EventArgs e)
        {
            MenuDataGrid.Visibility = Visibility.Collapsed;
            OrdersDataGrid.Visibility = Visibility.Collapsed;
            MenuOrdersDataGrid.Visibility = Visibility.Collapsed;
            EmployeeDataGrid.Visibility = Visibility.Collapsed;
            FeedbackDataGrid.Visibility = Visibility.Collapsed;
            RatingsDataGrid.Visibility = Visibility.Visible;
            AvailableDataGrid.Visibility = Visibility.Collapsed;
            PaymentMethodsDataGrid.Visibility = Visibility.Collapsed;
            PositionDataGrid.Visibility = Visibility.Collapsed;
            CategoryDataGrid.Visibility = Visibility.Collapsed;

            Tbx2.Visibility = Visibility.Collapsed;
            Tbx3.Visibility = Visibility.Collapsed;
            Tbx4.Visibility = Visibility.Collapsed;
            Tbx5.Visibility = Visibility.Collapsed;
            Tbx6.Visibility = Visibility.Collapsed;
            Tbx7.Visibility = Visibility.Collapsed;
        }
        public void ShowAvailableClick(object sender, EventArgs e)
        {
            MenuDataGrid.Visibility = Visibility.Collapsed;
            OrdersDataGrid.Visibility = Visibility.Collapsed;
            MenuOrdersDataGrid.Visibility = Visibility.Collapsed;
            EmployeeDataGrid.Visibility = Visibility.Collapsed;
            FeedbackDataGrid.Visibility = Visibility.Collapsed;
            RatingsDataGrid.Visibility = Visibility.Collapsed;
            AvailableDataGrid.Visibility = Visibility.Visible;
            PaymentMethodsDataGrid.Visibility = Visibility.Collapsed;
            PositionDataGrid.Visibility = Visibility.Collapsed;
            CategoryDataGrid.Visibility = Visibility.Collapsed;

            Tbx2.Visibility = Visibility.Collapsed;
            Tbx3.Visibility = Visibility.Collapsed;
            Tbx4.Visibility = Visibility.Collapsed;
            Tbx5.Visibility = Visibility.Collapsed;
            Tbx6.Visibility = Visibility.Collapsed;
            Tbx7.Visibility = Visibility.Collapsed;
        }
        public void ShowPaymentMethodsClick(object sender, EventArgs e)
        {
            MenuDataGrid.Visibility = Visibility.Collapsed;
            OrdersDataGrid.Visibility = Visibility.Collapsed;
            MenuOrdersDataGrid.Visibility = Visibility.Collapsed;
            EmployeeDataGrid.Visibility = Visibility.Collapsed;
            FeedbackDataGrid.Visibility = Visibility.Collapsed;
            RatingsDataGrid.Visibility = Visibility.Collapsed;
            AvailableDataGrid.Visibility = Visibility.Collapsed;
            PaymentMethodsDataGrid.Visibility = Visibility.Visible;
            PositionDataGrid.Visibility = Visibility.Collapsed;
            CategoryDataGrid.Visibility = Visibility.Collapsed;

            Tbx2.Visibility = Visibility.Collapsed;
            Tbx3.Visibility = Visibility.Collapsed;
            Tbx4.Visibility = Visibility.Collapsed;
            Tbx5.Visibility = Visibility.Collapsed;
            Tbx6.Visibility = Visibility.Collapsed;
            Tbx7.Visibility = Visibility.Collapsed;
        }
        public void ShowPositionClick(object sender, EventArgs e)
        {
            MenuDataGrid.Visibility = Visibility.Collapsed;
            OrdersDataGrid.Visibility = Visibility.Collapsed;
            MenuOrdersDataGrid.Visibility = Visibility.Collapsed;
            EmployeeDataGrid.Visibility = Visibility.Collapsed;
            FeedbackDataGrid.Visibility = Visibility.Collapsed;
            RatingsDataGrid.Visibility = Visibility.Collapsed;
            AvailableDataGrid.Visibility = Visibility.Collapsed;
            PaymentMethodsDataGrid.Visibility = Visibility.Collapsed;
            PositionDataGrid.Visibility = Visibility.Visible;
            CategoryDataGrid.Visibility = Visibility.Collapsed;

            Tbx2.Visibility = Visibility.Collapsed;
            Tbx3.Visibility = Visibility.Collapsed;
            Tbx4.Visibility = Visibility.Collapsed;
            Tbx5.Visibility = Visibility.Collapsed;
            Tbx6.Visibility = Visibility.Collapsed;
            Tbx7.Visibility = Visibility.Collapsed;
        }
        public void ShowCategoryClick(object sender, EventArgs e)
        {
            MenuDataGrid.Visibility = Visibility.Collapsed;
            OrdersDataGrid.Visibility = Visibility.Collapsed;
            MenuOrdersDataGrid.Visibility = Visibility.Collapsed;
            EmployeeDataGrid.Visibility = Visibility.Collapsed;
            FeedbackDataGrid.Visibility = Visibility.Collapsed;
            RatingsDataGrid.Visibility = Visibility.Collapsed;
            AvailableDataGrid.Visibility = Visibility.Collapsed;
            PaymentMethodsDataGrid.Visibility = Visibility.Collapsed;
            PositionDataGrid.Visibility = Visibility.Collapsed;
            CategoryDataGrid.Visibility = Visibility.Visible;

            Tbx2.Visibility = Visibility.Collapsed;
            Tbx3.Visibility = Visibility.Collapsed;
            Tbx4.Visibility = Visibility.Collapsed;
            Tbx5.Visibility = Visibility.Collapsed;
            Tbx6.Visibility = Visibility.Collapsed;
            Tbx7.Visibility = Visibility.Collapsed;
        }


        private void ButtonInsertClick(object sender, RoutedEventArgs e)
        {

            if (MenuDataGrid.Visibility == Visibility.Visible)
            {

                if (!ContainsLetters(Tbx2.Text) && !ContainsLetters(Tbx3.Text) && !ContainsLetters(Tbx4.Text) && !ContainsLetters(Tbx5.Text))
                {
                    menu.InsertMenu(Tbx1.Text, Convert.ToInt32(Tbx2.Text), Convert.ToInt32(Tbx3.Text), Convert.ToInt32(Tbx4.Text), Convert.ToInt32(Tbx5.Text));
                    MenuDataGrid.ItemsSource = menu.GetData();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, проверьте данные и попробуйте снова.");
                }
            }


            if (OrdersDataGrid.Visibility == Visibility.Visible)
            {

                string input = Tbx1.Text;
                DateTime date;
                if (DateTime.TryParseExact(input, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    if (!ContainsLetters(Tbx1.Text) && !ContainsLetters(Tbx2.Text) && !ContainsLetters(Tbx3.Text) && !ContainsLetters(Tbx4.Text) && !ContainsLetters(Tbx5.Text))
                    {
                        orders.InsertOrders(Tbx1.Text, Convert.ToInt32(Tbx2.Text), Convert.ToInt32(Tbx3.Text), Convert.ToInt32(Tbx4.Text), Convert.ToInt32(Tbx5.Text));
                        OrdersDataGrid.ItemsSource = orders.GetData();
                    }
                    else
                    {
                        MessageBox.Show("Пожалуйста, проверьте данные и попробуйте снова.");
                    }

                }
                else
                {
                    MessageBox.Show("Дата не соответствует требуемому формату (число.месяц.год)");
                }
            }
            if (EmployeeDataGrid.Visibility == Visibility.Visible)
            {
                if (!ContainsNumbers(Tbx1.Text) && !ContainsNumbers(Tbx2.Text) && !ContainsNumbers(Tbx3.Text) && !ContainsLetters(Tbx4.Text) && !ContainsLetters(Tbx5.Text))
                {
                    int age = Convert.ToInt32(Tbx5.Text);
                    if (age >= 18 && age < 100)
                    {
                        employee.InsertEmployee(Tbx1.Text, Tbx2.Text, Tbx3.Text, Convert.ToInt32(Tbx4.Text), Convert.ToInt32(Tbx5.Text), Tbx6.Text, Convert.ToInt32(Password.Password));
                        EmployeeDataGrid.ItemsSource = employee.GetData();
                    }
                    else
                    {
                        MessageBox.Show("Возраст работника должен быть от 18 до 99 лет.");
                    }
                }
                else
                {
                    MessageBox.Show("Пожалуйста, проверьте правильность введенных данных.");
                }
            }



            if (FeedbackDataGrid.Visibility == Visibility.Visible)
            {
                if (!ContainsLetters(Tbx1.Text) && !ContainsLetters(Tbx3.Text))
                {
                    feedback.InsertFeedback(Convert.ToInt32(Tbx1.Text), Tbx2.Text, Convert.ToInt32(Tbx3.Text));
                    FeedbackDataGrid.ItemsSource = feedback.GetData();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, в полях 'CustomerID' и 'RatingID' должны быть только цифры.");
                }
            }
            if (RatingsDataGrid.Visibility == Visibility.Visible)
            {
                if (!ContainsLetters(Tbx1.Text))
                {
                    rating.InsertRatings(Convert.ToInt32(Tbx1.Text));
                    RatingsDataGrid.ItemsSource = rating.GetData();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, проверьте данные и повторите попытку.");
                }
            }
            if (AvailableDataGrid.Visibility == Visibility.Visible)
            {
                if (!ContainsNumbers(Tbx1.Text))
                {
                    available.InsertAvailable(Tbx1.Text);
                    AvailableDataGrid.ItemsSource = available.GetData();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, в поле не должны быть цифры.");
                }
            }
            if (PaymentMethodsDataGrid.Visibility == Visibility.Visible)
            {
                if (!ContainsNumbers(Tbx1.Text))
                {
                    payment.InsertPayment(Tbx1.Text);
                    PaymentMethodsDataGrid.ItemsSource = payment.GetData();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, в поле должны быть только буквы.");
                }
            }
            if (PositionDataGrid.Visibility == Visibility.Visible)
            {
                if (!ContainsNumbers(Tbx1.Text))
                {
                    position.InsertPosition(Tbx1.Text);
                    PositionDataGrid.ItemsSource = position.GetData();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, в поле не должны быть цифры.");
                }
            }
            if (CategoryDataGrid.Visibility == Visibility.Visible)
            {
                if (!ContainsNumbers(Tbx1.Text))
                {
                    category.InsertCategory(Tbx1.Text);
                    CategoryDataGrid.ItemsSource = category.GetData();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, в поле не должны быть цифры.");
                }
            }
            if (MenuOrdersDataGrid.Visibility == Visibility.Visible)
            {
                if (!ContainsLetters(Tbx1.Text) && !ContainsLetters(Tbx2.Text))
                {
                    menu_orders.InsertMenuOrders(Convert.ToInt32(Tbx1.Text), Convert.ToInt32(Tbx2.Text));
                    MenuOrdersDataGrid.ItemsSource = menu_orders.GetData();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, в полях должны быть только цифры.");
                }
            }
        }

        // Метод для проверки наличия букв в строке
        bool ContainsLetters(string input)
        {


            return input.Any(char.IsLetter);

        }
        // Метод для проверки наличия цифр в строке
        bool ContainsNumbers(string input)
        {
            return input.Any(char.IsDigit);

        }


        private void ButtonUpdateClick(object sender, RoutedEventArgs e)
        {
            if (MenuDataGrid.Visibility == Visibility.Visible)
            {
                if (!ContainsLetters(Tbx2.Text) && !ContainsLetters(Tbx3.Text) && !ContainsLetters(Tbx4.Text) && !ContainsLetters(Tbx5.Text))
                {

                    object ID1 = (MenuDataGrid.SelectedItem as DataRowView).Row[0];
                    menu.UpdateMenu(Tbx1.Text, Convert.ToInt32(Tbx2.Text), Convert.ToInt32(Tbx3.Text), Convert.ToInt32(Tbx4.Text), Convert.ToInt32(Tbx5.Text), Convert.ToInt32(ID1));
                    MenuDataGrid.ItemsSource = menu.GetData();

                }
                else
                {
                    MessageBox.Show("Проверьте данные и повторите попытку");
                }
            }
            if (OrdersDataGrid.Visibility == Visibility.Visible)
            {
                if (!ContainsLetters(Tbx1.Text) && !ContainsLetters(Tbx2.Text) && !ContainsLetters(Tbx3.Text) && !ContainsLetters(Tbx4.Text) && !ContainsLetters(Tbx5.Text))
                {

                    object ID2 = (OrdersDataGrid.SelectedItem as DataRowView).Row[0];
                    orders.UpdateOrders(Tbx1.Text, Convert.ToInt32(Tbx2.Text), Convert.ToInt32(Tbx3.Text), Convert.ToInt32(Tbx4.Text), Convert.ToInt32(Tbx5.Text), Convert.ToInt32(ID2));
                    OrdersDataGrid.ItemsSource = orders.GetData();
                }
                else
                {
                    MessageBox.Show("Проверьте данные и повторите попытку");
                }
            }
            if (EmployeeDataGrid.Visibility == Visibility.Visible)
            {
                if (!ContainsNumbers(Tbx1.Text) && !ContainsNumbers(Tbx2.Text) && !ContainsNumbers(Tbx3.Text) && !ContainsLetters(Tbx4.Text) && !ContainsLetters(Tbx5.Text))
                {

                    int age;
                    if (int.TryParse(Tbx5.Text, out age))
                    {
                        if (age >= 18 && age < 100)
                        {

                            object ID3 = (EmployeeDataGrid.SelectedItem as DataRowView).Row[0];
                            employee.UpdateEmployee(Tbx1.Text, Tbx2.Text, Tbx3.Text, Convert.ToInt32(Tbx4.Text), age, Tbx6.Text, Convert.ToInt32(Tbx7.Text), Convert.ToInt32(ID3));

                            EmployeeDataGrid.ItemsSource = employee.GetData();
                        }
                        else
                        {
                            MessageBox.Show("Возраст работника должен быть от 18 до 99 лет.");

                        }
                    }

                }
                else
                {
                    MessageBox.Show("Проверьте данные и повторите попытку");
                }
            }
            if (FeedbackDataGrid.Visibility == Visibility.Visible)
            {
                if (!ContainsLetters(Tbx1.Text) && !ContainsLetters(Tbx3.Text))
                {

                    object ID4 = (FeedbackDataGrid.SelectedItem as DataRowView).Row[0];
                    feedback.UpdateFeedback(Convert.ToInt32(Tbx1.Text), Tbx2.Text, Convert.ToInt32(Tbx3.Text), Convert.ToInt32(ID4));
                    FeedbackDataGrid.ItemsSource = feedback.GetData();

                }
                else
                {
                    MessageBox.Show("Проверьте данные и повторите попытку");
                }
            }
            if (RatingsDataGrid.Visibility == Visibility.Visible)
            {
                if (!ContainsLetters(Tbx1.Text))
                {
                    object ID5 = (RatingsDataGrid.SelectedItem as DataRowView).Row[0];
                    rating.UpdateRatings(Convert.ToInt32(Tbx1.Text), Convert.ToInt32(ID5));
                    RatingsDataGrid.ItemsSource = rating.GetData();

                }
                else
                {
                    MessageBox.Show("Проверьте данные и повторите попытку");
                }
            }
            if (AvailableDataGrid.Visibility == Visibility.Visible)
            {
                if (!ContainsNumbers(Tbx1.Text))
                {
                    object ID6 = (AvailableDataGrid.SelectedItem as DataRowView).Row[0];
                    available.UpdateAvailable(Tbx1.Text, Convert.ToInt32(ID6));
                    AvailableDataGrid.ItemsSource = available.GetData();

                }
                else
                {
                    MessageBox.Show("Проверьте данные и повторите попытку");
                }
            }
            if (PaymentMethodsDataGrid.Visibility == Visibility.Visible)
            {
                if (!ContainsNumbers(Tbx1.Text))
                {
                    object ID7 = (PaymentMethodsDataGrid.SelectedItem as DataRowView).Row[0];
                    payment.UpdatePayment(Tbx1.Text, Convert.ToInt32(ID7));
                    PaymentMethodsDataGrid.ItemsSource = payment.GetData();

                }
                else
                {
                    MessageBox.Show("Проверьте данные и повторите попытку");
                }
            }
            if (PositionDataGrid.Visibility == Visibility.Visible)
            {
                if (!ContainsNumbers(Tbx1.Text))
                {
                    object ID8 = (PositionDataGrid.SelectedItem as DataRowView).Row[0];
                    position.UpdatePosition(Tbx1.Text, Convert.ToInt32(ID8));
                    PositionDataGrid.ItemsSource = position.GetData();

                }
                else
                {

                }
                MessageBox.Show("Проверьте данные и повторите попытку");
            }
            if (CategoryDataGrid.Visibility == Visibility.Visible)
            {
                if (!ContainsNumbers(Tbx1.Text))
                {
                    object ID9 = (CategoryDataGrid.SelectedItem as DataRowView).Row[0];
                    category.UpdateCategory(Tbx1.Text, Convert.ToInt32(ID9));
                    CategoryDataGrid.ItemsSource = category.GetData();

                }
                else
                {

                    MessageBox.Show("Проверьте данные и повторите попытку");
                }
            }
            if (MenuDataGrid.Visibility == Visibility.Visible)
            {
                if (!ContainsLetters(Tbx1.Text) && !ContainsLetters(Tbx2.Text))
                {
                    object ID10 = (MenuOrdersDataGrid.SelectedItem as DataRowView).Row[0];
                    menu_orders.UpdateMenuOrders(Convert.ToInt32(Tbx1.Text), Convert.ToInt32(Tbx2.Text), Convert.ToInt32(ID10));
                    MenuOrdersDataGrid.ItemsSource = menu_orders.GetData();

                }
                else
                {
                    MessageBox.Show("Проверьте данные и повторите попытку");
                }
            }
        }
        private void ButtonDeleteClick(object sender, RoutedEventArgs e)
        {
            if (MenuDataGrid.Visibility == Visibility.Visible)
            {
                object ID1 = (MenuDataGrid.SelectedItem as DataRowView).Row[0];
                menu.DeleteMenu(Convert.ToInt32(ID1));
                MenuDataGrid.ItemsSource = menu.GetData();
            }
            if (OrdersDataGrid.Visibility == Visibility.Visible)
            {
                object ID2 = (OrdersDataGrid.SelectedItem as DataRowView).Row[0];
                orders.DeleteOrders(Convert.ToInt32(ID2));
                OrdersDataGrid.ItemsSource = orders.GetData();


            }
            if (EmployeeDataGrid.Visibility == Visibility.Visible)
            {
                object ID3 = (EmployeeDataGrid.SelectedItem as DataRowView).Row[0];
                employee.DeleteEmployee(Convert.ToInt32(ID3));
                EmployeeDataGrid.ItemsSource = employee.GetData();

            }
            if (FeedbackDataGrid.Visibility == Visibility.Visible)
            {
                object ID4 = (FeedbackDataGrid.SelectedItem as DataRowView).Row[0];
                feedback.DeleteFeedback(Convert.ToInt32(ID4));
                FeedbackDataGrid.ItemsSource = feedback.GetData();
            }
            if (RatingsDataGrid.Visibility == Visibility.Visible)
            {
                object ID5 = (RatingsDataGrid.SelectedItem as DataRowView).Row[0];
                rating.DeleteRatings(Convert.ToInt32(ID5));
                RatingsDataGrid.ItemsSource = rating.GetData();
            }
            if (AvailableDataGrid.Visibility == Visibility.Visible)
            {
                object ID6 = (AvailableDataGrid.SelectedItem as DataRowView).Row[0];
                available.DeleteAvailable(Convert.ToInt32(ID6));
                AvailableDataGrid.ItemsSource = available.GetData();
            }
            if (PaymentMethodsDataGrid.Visibility == Visibility.Visible)
            {
                object ID7 = (PaymentMethodsDataGrid.SelectedItem as DataRowView).Row[0];
                payment.DeletePayment(Convert.ToInt32(ID7));
                PaymentMethodsDataGrid.ItemsSource = payment.GetData();
            }
            if (PositionDataGrid.Visibility == Visibility.Visible)
            {
                object ID8 = (PositionDataGrid.SelectedItem as DataRowView).Row[0];
                position.DeletePosition(Convert.ToInt32(ID8));
                PositionDataGrid.ItemsSource = position.GetData();
            }
            if (CategoryDataGrid.Visibility == Visibility.Visible)
            {
                object ID9 = (CategoryDataGrid.SelectedItem as DataRowView).Row[0];
                category.DeleteCategory(Convert.ToInt32(ID9));
                CategoryDataGrid.ItemsSource = category.GetData();
            }
            if (MenuOrdersDataGrid.Visibility == Visibility.Visible)
            {
                object ID10 = (MenuOrdersDataGrid.SelectedItem as DataRowView).Row[0];
                menu_orders.DeleteMenuOrders(Convert.ToInt32(ID10));
                MenuOrdersDataGrid.ItemsSource = menu_orders.GetData();
            }
        }
        public static string CalculateSHA256(string input)
        {
            // Преобразование входной строки в массив байтов
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            // Создание объекта SHA256
            using (SHA256 sha256 = SHA256.Create())
            {
                // Вычисление хеша для входных данных
                byte[] hashBytes = sha256.ComputeHash(inputBytes);

                // Преобразование массива байтов в строку шестнадцатеричного представления
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2")); // Форматирование байта в двузначное шестнадцатеричное число
                }
                return builder.ToString();
            }
        }

    }
}
