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

using Practica5.Coffee_House_Cosy_CoffeeDataSetTableAdapters;

namespace Practica5
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        EmployeeTableAdapter employee = new EmployeeTableAdapter();
        public Window2()
        {
            InitializeComponent();

        }
        
private void AutorisationClick2(object sender, RoutedEventArgs e)
        {
            var allLogins = employee.GetData().Rows;
            bool credentialsFound = false;

            for (int i = 0; i < allLogins.Count; i++)
            {
                if (allLogins[i][6].ToString() == LoginTbx.Text &&
                    allLogins[i][7].ToString() == PasswordTbx.Password)
                {
                    int roleId = (int)allLogins[i][0];
                    credentialsFound = true;

                    switch (roleId)
                    {
                        case 1:
                            Window3 window3 = new Window3();
                            window3.Show();
                            break;
                        case 2:
                            Window4 window4 = new Window4();
                            window4.Show();
                            break;

                    }
                    if (!credentialsFound)
                    {
                        MessageBox.Show("Неправильно введен пароль или логин.");
                    }

                }
            }
        }
    }
}
