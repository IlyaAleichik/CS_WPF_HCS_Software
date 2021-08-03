using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.IO;
using System.Configuration;
using System.Windows.Data;
using Newtonsoft.Json;

namespace TKP.Model
{
    public class DataBase : BaseViewModel
    {
        private static DataBase _Instance = new DataBase();
        public static DataBase GetInstance() => _Instance;

        public ObservableCollection<string> KeyWords { get; set; }
        private DataBase()
        {
            KeyWords = File.Exists("KeyWordsData.json") ? JsonConvert.DeserializeObject<ObservableCollection<string>>(File.ReadAllText("KeyWordsData.json")) : new ObservableCollection<string>();
            BindingOperations.EnableCollectionSynchronization(KeyWords, new object());
            KeyWords.CollectionChanged += (s, e) =>
            {
                File.WriteAllText("KeyWordsData.json", JsonConvert.SerializeObject(KeyWords));
            };

        }
    }
}
