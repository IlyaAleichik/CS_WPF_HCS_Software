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
using System.Configuration;
using System.Data.SQLite;
using System.Data;


using TKP.ViewModel;
using System.ComponentModel;

namespace TKP.Views
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
     
        public LoginWindow()
        {

            
            InitializeComponent();
        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        
            var h = new Home();
        
            //LoginWindow a = new LoginWindow();
            //a.Owner = this;
          
           SQLiteConnection sqlCon = new SQLiteConnection(@"Data Source=data/users.db; Version=3; ");
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                String query = "SELECT COUNT(1) FROM [Users] WHERE Email=@Email AND Password=@Password";
                SQLiteCommand sqlCmd = new SQLiteCommand(query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;

                sqlCmd.Parameters.AddWithValue("@Email", txtUsername.Text);
                sqlCmd.Parameters.AddWithValue("@Password", txtPassword.Password);
                
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {

                    h.Show();
                    this.Close();


                }
                else
                {
            
                    MessageBox.Show("Неверный email или пароль!  ");



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }

            
            
        }
       
        
    }
}
