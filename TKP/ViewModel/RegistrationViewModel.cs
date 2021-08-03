using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using TKP.Views;
using TKP.Model;
using System.Data.SqlClient;
using DevExpress.Mvvm;

namespace TKP.ViewModel
{
    public class RegistrationViewModel : BaseViewModel
    {


        private string _txtName { get; set; }
        public string txtName
        {
            get => _txtName;
            set { _txtName = value; }
        }
        private string _txtSurname { get; set; }
        public string txtSurname
        {
            get => _txtSurname;
            set { _txtSurname = value; }
        }
        private string _txtPatronymic { get; set; }
        public string txtPatronymic {
            get => _txtPatronymic;
            set { _txtPatronymic = value; }

        }
        private string _txtEmail { get; set; }
        public string txtEmail
        {
            get => _txtEmail;
            set { _txtEmail = value; }

        }
        private int _txtPhone { get; set; }
        public int txtPhone
        {
            get => _txtPhone;
            set { _txtPhone = value; }

        }
        private string _txtPosition { get; set; }
        public string txtPosition
        {
            get => _txtPosition;
            set { _txtPosition = value; }

        }
        private string _txtPassword { get; set; }
        public string txtPassword
        {
            get => _txtPassword;
            set { _txtPassword = value; }

        }

        public Action CloseAction { get; set; }

        public DelegateCommand<Window> Reg
        {

            get
            {

                return new DelegateCommand<Window>((w) =>
                {

       
                //    SqlConnection sqlCon = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=HCSDataBase; Integrated Security=True;");
                //    try
                //    {
                //        if (sqlCon.State == ConnectionState.Closed)
                //            sqlCon.Open();
                //        String query = "INSERT INTO users(Name,Surname,Patronymic,Email,Password) VALUES(@Name,@Surname,@Patronymic,@Email,@Password)";
                //        SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                //        sqlCmd.CommandType = CommandType.Text;

                //        sqlCmd.Parameters.AddWithValue("@Name", _txtEmail);
                //        sqlCmd.Parameters.AddWithValue("@Surname", _txtSurname);
                //        sqlCmd.Parameters.AddWithValue("@Patronymic",_txtPatronymic);
                //        sqlCmd.Parameters.AddWithValue("@Email",_txtEmail);
                //       // sqlCmd.Parameters.AddWithValue("@Phone", txtPhone );
                //       // sqlCmd.Parameters.AddWithValue("@Position",txtPosition);
                //        sqlCmd.Parameters.AddWithValue("@Password", _txtPassword);
                //        MessageBox.Show("Регистрация прошла успешно  
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show(ex.Message);
                //    }
                //    finally
                //    {
                //        sqlCon.Close();
                //    }
                   


                });


            }

        }



    }
}
