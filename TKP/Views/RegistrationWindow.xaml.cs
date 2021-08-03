using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
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
using TKP.ViewModel;
namespace TKP.Views
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {

        
        public RegistrationWindow()
        {
            InitializeComponent();
            RegistrationViewModel vm = new RegistrationViewModel();
            this.DataContext = vm;
            if (vm.CloseAction == null)
                vm.CloseAction = new Action(this.Close);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var reg = new RegistrationWindow();
            SQLiteConnection connect = new SQLiteConnection(@"Data Source=data/users.db; version=3");
            string sql = "INSERT INTO users (Name, Surname, Patronymic,Email,Password) VALUES (@Name, @Surname, @Patronymic,@Email,@Password)";
            SQLiteCommand cmd_SQL = new SQLiteCommand(sql, connect);

            cmd_SQL.Parameters.AddWithValue("@Name", txtEmail.Text);
            cmd_SQL.Parameters.AddWithValue("@Surname", txtSurname.Text);
            cmd_SQL.Parameters.AddWithValue("@Patronymic", txtPatronymic.Text);
            cmd_SQL.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd_SQL.Parameters.AddWithValue("@Phone", txtPhone );
            // sqlCmd.Parameters.AddWithValue("@Position",txtPosition);
            cmd_SQL.Parameters.AddWithValue("@Password", txtPassword.Text);

            try
            {
                connect.Open();
                int n = cmd_SQL.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new ApplicationException("error insert new_tovar", ex);
            }
            finally
            {
                connect.Close();
            }

            this.Close();
        }
    }
}
