using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKP.Views;
using TKP.Model;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows;

using System.Windows.Controls;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using DevExpress.Mvvm;
using TKP.Styles.CustomizedWindow;
//using TKP.Models;

namespace TKP.ViewModel
{
    public class LoginViewModel : BaseViewModel
    {


        // открытие формы регистрации
        public DelegateCommand Register
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    var reg = new RegistrationWindow();
                    var vm = new RegistrationViewModel();
                  
                    reg.DataContext = vm;
                    reg.ShowDialog();


                });

            }
        }
        // открытие формы восстановления пароля
        public DelegateCommand RemeberReg
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    var rem = new DialogWindow();
                    rem.ShowDialog();


                });

            }
        }

      


        //ввод имени или email-a
        private string _InputTextUser { get; set; }
        public string InputTextUser
        {
            get => _InputTextUser;
            set
            {
                _InputTextUser = value;             
            }
        }
        //ввод пароля
        private string _InputTextPassword { get; set; }
        public string InputTextPassword
        {
            get => _InputTextPassword;
            set
            {
                _InputTextPassword = value;
            }
        }

        //  Функция входа в систему
        public DelegateCommand Login
        {
           
            get
            {
                return new DelegateCommand(() =>
                {

                    //var u = new User();
                    //u.Email = InputTextUser;
                    //u.Password = InputTextPassword;

                    //using (HCSDataBaseEntities db = new HCSDataBaseEntities()) 
                    //    db.Users.Add(u);
                    //    db.SaveChanges();
                    //}

                    //var main = new Home();
                    //var login = new LoginWindow();

                    //SqlConnection sqlCon = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=HCSDataBase; Integrated Security=True;");
                    //try
                    //{
                    //    if (sqlCon.State == ConnectionState.Closed)
                    //        sqlCon.Open();
                    //    String query = "SELECT COUNT(1) FROM [user] WHERE email=@email AND password=@password";
                    //    SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                    //    sqlCmd.CommandType = CommandType.Text;

                    //    sqlCmd.Parameters.AddWithValue("@Email", InputTextUser);
                    //    sqlCmd.Parameters.AddWithValue("@Password", InputTextPassword);

                    //    int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                    //    if (count == 1)
                    //    {

                    //        main.Show();
                    //        login.Close();
                    //    }
                    //    else
                    //    {

                    //        MessageBox.Show("Username or password is incorrect.");
                    //    }
                    //}
                    //catch (Exception ex)
                    //{
                    //    MessageBox.Show(ex.Message);
                    //}
                    //finally
                    //{
                    //    sqlCon.Close();
                    //}

                });

            }
        }
    }
}
