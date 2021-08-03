using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TKP.Model;
using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Input;

namespace TKP.ViewModel
{
    class EditViewModel : BaseViewModel
    {
        public House HouseInfo { get; set; }
        public DelegateCommand<Window> Save
        {
            get
            {
                return new DelegateCommand<Window>((w) =>
                {
                    foreach (var key in HouseInfo.KeyWords)
                    {
                       
                        if (DataBase.GetInstance().KeyWords.FirstOrDefault(s => key.Value == s) == null)
                        {
                            DataBase.GetInstance().KeyWords.Add(key.Value);
                        }
                    }
                    w?.Close();
                });
            }
        }

    }
}
