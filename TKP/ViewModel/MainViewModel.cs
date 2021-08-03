using DevExpress.Mvvm;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows;
using TKP;
using TKP.Model;
using TKP.Views;
using System.Windows.Controls;
using Microsoft.Office.Core;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Win32;
using System.Collections.Generic;
using System.Text;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Runtime.InteropServices;
using System.Windows.Interop;
using TKP.ViewModel;



namespace TKP.ViewModel
{
    public class MainViewModel : BaseViewModel
    {

       

        public ObservableCollection<House> Houses { get; set; }
        public ICollectionView HousesView { get; set; }
        public House SelectedHouse { get; set; }

        List<string> _source = new List<string> { "готов", "не готов" };
        public List<string> Source
        {
            get { return _source; }
        }

        string _theSelectedItem = null;
        public string TheSelectedItem
        {
            get { return _theSelectedItem; }
            set { _theSelectedItem = value; } 
        }


        

        // Поиск
        private string _SearchText { get; set; }
        public string SearchText
        {
            get => _SearchText;
            set
            {
                try
                {
                    _SearchText = value;
                    HousesView.Filter = (obj) =>
                    {
                        if (obj is House house)
                        {
                            switch (SearchText.FirstOrDefault())
                            {
                                case '@': return house.KeyWords.FirstOrDefault(s => s.Value.ToLower().Contains(SearchText.Remove(0, 1).ToLower())) != null;

                                case '$':
                                    if (DateTime.TryParse(SearchText.Remove(0, 1), out DateTime date))
                                        return house.PublishData.Date == date.Date;
                                    return false;

                                default: return house.Address.ToLower().Contains(SearchText.ToLower()) || house.Num.ToLower().Contains(SearchText.ToLower());
                            }
                        }

                        return false;
                    };
                    HousesView.Refresh();
                }
                catch { }
               

            }
        }

        // Frame навигация

        private Page _CurrentPage;
        public Page CurrentPage
        {
            get => _CurrentPage;
            set
            {
                _CurrentPage = value;
            }
        }

        public Page Helps;
    
        public MainViewModel()
        {


        
            try
            {

                //Helps = new Main();
                //CurrentPage = Helps;

                OverlayService.GetInstance().Show = (str) =>
                {
                    OverlayService.GetInstance().Text = str;
                };


                //Серилизация БД JSON и запись в коллекцию ObservableCollection
                Houses = File.Exists("HousesData.json") ? JsonConvert.DeserializeObject<ObservableCollection<House>>(File.ReadAllText("HousesData.json")) : new ObservableCollection<House>();
                Houses.CollectionChanged += (s, e) =>
                {
                    File.WriteAllText("HousesData.json", JsonConvert.SerializeObject(Houses));
                };
                BindingOperations.EnableCollectionSynchronization(Houses, new object());
                HousesView = CollectionViewSource.GetDefaultView(Houses);

            
            }
            catch { }

          


        }

        #region Переменные получающие и возвращающие вводимые значения

        private string _FirstName { get; set; }
        public string FirstName
        {
            get => _FirstName;
            set { _FirstName = value; }
        }
        private string _LastName { get; set; }
        public string LastName
        {
            get => _LastName;
            set { _LastName = value; }
        }
        private string _Patronymic { get; set; }
        public string Patronymic
        {
            get => _Patronymic;
            set { _Patronymic = value; }
        }

        private string _Num { get; set; }
        public string Num
        {
            get => _Num;
            set { _Num = value; }
        }
        private string _Korp { get; set; }
        public string Korp
        {
            get => _Korp;
            set { _Korp = value; }
        }






        private string _MatWalls { get; set; }
        public string MatWalls
        {
            get => _MatWalls;
            set { _MatWalls = value; }
        }
        private string _Basement { get; set; }
        public string Basement
        {
            get => _Basement;
            set { _Basement = value; }
        }

        private string _Predsedateli { get; set; }
        public string Predsedateli
        {
            get => _Predsedateli;
            set { _Predsedateli = value; }
        }
        private string _Predstoviteli { get; set; }
        public string Predstoviteli
        {
            get => _Predstoviteli;
            set { _Predstoviteli = value; }
        }
    

        private string _Address { get; set; }
        public string Address
        {
            get => _Address;
            set { _Address = value; }
        }
        private string _City { get; set; }
        public string City
        {
            get => _City;
            set { _City = value; }
        }
        private string _Owner { get; set; }
        public string Owner {
            get => _Owner;
            set { _Owner = value; }
        }
        private string _ExpOrg { get; set; }
        public string ExpOrg
        {
            get => _ExpOrg;
            set { _ExpOrg = value; }
        }
        private string _CountFloor { get; set; }
        public string CountFloor
        {
            get => _CountFloor;
            set { _CountFloor = value; }
        }
        private string _ReadyWinter { get; set; }
        public string ReadyWinter
        {
            get => _ReadyWinter;
            set { _ReadyWinter = value; }
        }

        private string _Year { get; set; }
        public string Year
        {
            get => _Year;
            set { _Year = value; }
        }

        private string _Description { get; set; }
        public string Description
        {
            get => _Description;
            set { _Description = value; }
        }
      
    
        #endregion

        //Добовление элемента в ListView
        public ICommand AddItem
        {
            get
            {
                return new DelegateCommand(async () =>
                {

                  


                    await Task.Factory.StartNew(() =>
                        {
                            Houses.Add(new House
                            {

                                Address = _Address,
                              
                                City = _City,
                                Owner = _Owner,
                                ExpOrg = _ExpOrg,
                                Year = _Year,
                                CountFloor = _CountFloor,
                                PublishData = DateTime.Now,
                                ReadyWinter = _theSelectedItem,
                                Description = _Description,
                                //FirstName = _FirstName,
                                //LastName = _LastName,
                                //Patronymic = _Patronymic,
                                Num = _Num,
                                Korp = _Korp,
                                MatWalls = _MatWalls,
                                Basement = _Basement,
                                Predsedateli = _Predsedateli,
                                Predstoviteli = _Predstoviteli,
                                
                            });                                
                            
                            SelectedHouse = Houses.FirstOrDefault();
                            OverlayService.GetInstance().Close();
                        });
                    

                });
            }
        }

        DateTime date = new DateTime();
        SaveFileDialog saveFileDialog = new SaveFileDialog();

        public string TemplateFile;

        //Формирование отчета в  Word
        public ICommand Form
        {
            get
            {
                return new DelegateCommand<House>((house) =>
                {

                    string curDir = Directory.GetCurrentDirectory();
                    TemplateFile = String.Format("file:///{0}/template/TKP45Template.docx", curDir);
                    var wordApp = new Word.Application();
                    try
                    {
                        wordApp.Visible = false;
                        var wordDoc = wordApp.Documents.Open(TemplateFile);
                        ReplaceWordStub("{Address}", SelectedHouse.Address, wordDoc);
                        ReplaceWordStub("{City}", SelectedHouse.City, wordDoc);
                        ReplaceWordStub("{Owner}", SelectedHouse.Owner, wordDoc);
                        ReplaceWordStub("{ExpOrg}", SelectedHouse.ExpOrg, wordDoc);
                        ReplaceWordStub("{Year}", SelectedHouse.Year, wordDoc);
                        ReplaceWordStub("{CountFloor}", SelectedHouse.CountFloor, wordDoc);
                        ReplaceWordStub("{PublishData}", SelectedHouse.PublishData.ToString("d"), wordDoc);
                        ReplaceWordStub("{ReadyWinter}", SelectedHouse.ReadyWinter, wordDoc);
                        ReplaceWordStub("{Description}", SelectedHouse.Description, wordDoc);
                        //ReplaceWordStub("{FirstName}", SelectedHouse.FirstName, wordDoc);
                        //ReplaceWordStub("{LastName}", SelectedHouse.LastName, wordDoc);
                        //ReplaceWordStub("{Patronymic}", SelectedHouse.Patronymic, wordDoc);
                        ReplaceWordStub("{Num}", SelectedHouse.Num, wordDoc);
                        ReplaceWordStub("{Korp}", SelectedHouse.Korp, wordDoc);
                        ReplaceWordStub("{MatWalls}", SelectedHouse.MatWalls, wordDoc);
                        ReplaceWordStub("{Basement}", SelectedHouse.Basement, wordDoc);
                        ReplaceWordStub("{Predsedateli}", SelectedHouse.Predsedateli, wordDoc);
                        ReplaceWordStub("{Predstoviteli}", SelectedHouse.Predstoviteli, wordDoc);

                        saveFileDialog.Filter = "Документ Word  (*.docx*)|*.docx | All files (*.*)|*.*";
                        if (saveFileDialog.ShowDialog() == true)
                        {
                            curDir = saveFileDialog.FileName;
                        }
                        else
                        {
                            wordDoc.Close();
                        }
                        wordDoc.SaveAs(curDir);
                        wordDoc.Close();

                    }
                    catch { }



                });
            }
        }

        public void WordSave() {


       
        }
    
        //Замена ключевых слов в шаблоне на данные из БД
        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            try
            {
                var range = wordDocument.Content;
                range.Find.ClearFormatting();
                range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
            }
            catch { }
      
        }



        //// Редактирование
        public ICommand Edit
        {
            get
            {
                return new DelegateCommand<House>((house) =>
                {
                    var w = new EditWindow();
                    var vm = new EditViewModel
                    {
                        HouseInfo = house,
                    };
                    w.DataContext = vm;
                    w.ShowDialog();
                    File.WriteAllText("HousesData.json", JsonConvert.SerializeObject(Houses));

                }, (house) => house != null);
            }
        }

        // Сортировка
        public ICommand Sort
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    if (HousesView.SortDescriptions.Count > 0)
                    {
                        HousesView.SortDescriptions.Clear();
                    }
                    else
                    {
                        HousesView.SortDescriptions.Add(new SortDescription("Address", ListSortDirection.Ascending));
                    }
                });
            }
        }

        // О программе 
        public ICommand About
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    var about = new WindowAboutProgram();
                    about.ShowDialog(); 
                });
            }
        }
        //Удаление записи 
        public ICommand Delete
        {
            get
            {
                return new DelegateCommand<House>((house) =>
                {
                    Houses.Remove(house);
                    SelectedHouse = Houses.FirstOrDefault();

                }, (house) => house != null);
            }
        }

        //ввод ключевого слова в поле поиска 
        public ICommand KeyWordClick
        {
            get
            {
                return new DelegateCommand<KeyWordItem>((word) =>
                {
                    if (word != null)
                    {
                        SearchText = "@" + word.Value;
                    }
                });
            }
        }

        //кнопка Помощь
        public ICommand HelpDown
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    var h = new WindowHelp();
                    h.Show();
                });
            }
        }



    }
}
