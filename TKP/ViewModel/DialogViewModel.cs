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
using System.Net.Mail;
using System.Net;

namespace TKP.ViewModel
{
    class DialogViewModel : BaseViewModel
    {

        private string _InputText { get; set; }
        public string InputText
        {

            get => _InputText;
            set
            {
                _InputText = value;
            }
        }
        private int GetRand(int count)
        {
            List<int> nums = new List<int>();
            Random rand = new Random();

            int nr = 0;
            while (nums.Count != count)
            {
                nr = rand.Next(0, 9);
                if (!nums.Contains(nr))

                    nums.Add(nr);
            }

            string tmp = string.Empty;
            foreach (var num in nums)
                tmp += num;

            return Convert.ToInt32(tmp);
        }

        private Visibility _SelectedItem1 { get; set; }
        private Visibility _SelectedItem2 { get; set; }
        public Visibility VisibleProperty1
        {
            get { return _SelectedItem1;  }
            set { _SelectedItem1 = value; }
        }
        public Visibility VisibleProperty2
        {
            get { return _SelectedItem2; }
            set { _SelectedItem2 = value; }
        }

        public DelegateCommand EnterCode
        {
            get
            {
                const string message ="Ключ действителен. Продолжить?";
                const string message2 = "Ключ не действителен. Продолжить?";
                const string caption = "Test";
               
                return new DelegateCommand(() =>
                {
                    if (Convert.ToInt32(_InputText) == Key) {
                        MessageBox.Show(message, caption, MessageBoxButton.YesNo, MessageBoxImage.Exclamation);
                    }
                    else { MessageBox.Show(message2, caption, MessageBoxButton.YesNo, MessageBoxImage.Exclamation); }

                
                });

            }
        }

        private int Key { get; set; }
        public DelegateCommand EmailNext
        {
            get
            {
                return new DelegateCommand(() =>
                {


                    try
                    {

                        // отправитель - устанавливаем адрес и отображаемое в письме имя
                        MailAddress from = new MailAddress("Ilya.alejchik@outlook.com", "Abstract Studio");
                        // кому отправляем                          

                        MailAddress to = new MailAddress(_InputText);
                        // создаем объект сообщения
                        MailMessage m = new MailMessage(from, to);
                        // тема письма
                        m.Subject = "Тест-писмо";
                        // текст письма
                        Key = GetRand(4);
                        m.Body = "<h2>Код </h2>" + Key + "<h2>Письмо-тест работы smtp-клиента </h2>";
                        // письмо представляет код html
                        m.IsBodyHtml = true;
                        // адрес smtp-сервера и порт, с которого будем отправлять письмо
                        SmtpClient smtp = new SmtpClient("smtp.outlook.com", 587);
                        // логин и пароль
                        smtp.Credentials = new NetworkCredential("Ilya.alejchik@outlook.com", "Skyfall2016");
                        smtp.EnableSsl = true;
                        smtp.Send(m);
                        Console.Read();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                    _InputText = "";
                    _SelectedItem1 = Visibility.Visible;
                    _SelectedItem2 = Visibility.Hidden;
                });
            }
        }
        public DialogViewModel() {
            _SelectedItem1 = Visibility.Hidden;
        }
    }
}
