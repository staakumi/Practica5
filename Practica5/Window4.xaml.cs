using System;
using System.Collections.Generic;
using System.Data;
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

using Practica5.Coffee_House_Cosy_CoffeeDataSetTableAdapters;

namespace Practica5
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        MenuTableAdapter menu = new MenuTableAdapter();
        FeedbackTableAdapter feedback = new FeedbackTableAdapter();
        AvailableTableAdapter available = new AvailableTableAdapter();
        CategoryTableAdapter category = new CategoryTableAdapter();
        public Window4()
        {
            InitializeComponent();
            MenuDataGrid.ItemsSource = menu.GetData();
            FeedbackDataGrid.ItemsSource = feedback.GetData();
            AvailableDataGrid.ItemsSource = available.GetData();
            CategoryDataGrid.ItemsSource = category.GetData();
        }
        public void ShowMenuClick(object sender, EventArgs e)
        {

            MenuDataGrid.Visibility = Visibility.Visible;


            FeedbackDataGrid.Visibility = Visibility.Collapsed;

            AvailableDataGrid.Visibility = Visibility.Collapsed;


            CategoryDataGrid.Visibility = Visibility.Collapsed;


            Tbx1.Visibility = Visibility.Visible;
            Tbx2.Visibility = Visibility.Visible;
            Tbx3.Visibility = Visibility.Visible;
            Tbx4.Visibility = Visibility.Visible;
            Tbx5.Visibility = Visibility.Visible;

            Tbx6.Visibility = Visibility.Collapsed;
            Tbx7.Visibility = Visibility.Collapsed;
        }
        public void ShowFeedbackClick(object sender, EventArgs e)
        {
            MenuDataGrid.Visibility = Visibility.Collapsed;

            FeedbackDataGrid.Visibility = Visibility.Visible;

            AvailableDataGrid.Visibility = Visibility.Collapsed;

            CategoryDataGrid.Visibility = Visibility.Collapsed;

            Tbx1.Visibility = Visibility.Visible;
            Tbx2.Visibility = Visibility.Visible;
            Tbx3.Visibility = Visibility.Visible;

            Tbx4.Visibility = Visibility.Collapsed;
            Tbx5.Visibility = Visibility.Collapsed;
            Tbx6.Visibility = Visibility.Collapsed;
            Tbx7.Visibility = Visibility.Collapsed;

        }
        public void ShowAvailableClick(object sender, EventArgs e)
        {
            MenuDataGrid.Visibility = Visibility.Collapsed;

            FeedbackDataGrid.Visibility = Visibility.Collapsed;

            AvailableDataGrid.Visibility = Visibility.Visible;

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

            FeedbackDataGrid.Visibility = Visibility.Collapsed;

            AvailableDataGrid.Visibility = Visibility.Collapsed;

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



        }
        private void ButtonDeleteClick(object sender, RoutedEventArgs e)
        {
            if (MenuDataGrid.Visibility == Visibility.Visible)
            {
                object ID1 = (MenuDataGrid.SelectedItem as DataRowView).Row[0];
                menu.DeleteMenu(Convert.ToInt32(ID1));
                MenuDataGrid.ItemsSource = menu.GetData();
            }
            if (FeedbackDataGrid.Visibility == Visibility.Visible)
            {
                object ID4 = (FeedbackDataGrid.SelectedItem as DataRowView).Row[0];
                feedback.DeleteFeedback(Convert.ToInt32(ID4));
                FeedbackDataGrid.ItemsSource = feedback.GetData();
            }
            if (FeedbackDataGrid.Visibility == Visibility.Visible)
            {
                object ID4 = (FeedbackDataGrid.SelectedItem as DataRowView).Row[0];
                feedback.DeleteFeedback(Convert.ToInt32(ID4));
                FeedbackDataGrid.ItemsSource = feedback.GetData();
            }
            if (CategoryDataGrid.Visibility == Visibility.Visible)
            {
                object ID9 = (CategoryDataGrid.SelectedItem as DataRowView).Row[0];
                category.DeleteCategory(Convert.ToInt32(ID9));
                CategoryDataGrid.ItemsSource = category.GetData();
            }
        }

    }
}
