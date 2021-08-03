using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKP.Model;

namespace TKP.Model
{
    public class House : BaseViewModel
    {

        ////public string FirstName { get; set; }
        ////public string LastName { get; set; }
        ////public string Patronymic { get; set; 
        public string City { get; set; }
        public DateTime PublishData { get; set; }
        public string PublishDataFormat { get; set; }
        public string Num { get; set; }
        public string Korp { get; set; }
        public string Address { get; set; }
        public string Owner { get; set; }
        public string ExpOrg { get; set; }
        public string Year { get; set; }
        public string MatWalls { get; set; }
        public string CountFloor { get; set; }
        public string Basement { get; set; }
        public string ReadyWinter { get; set; }
        public string Predsedateli { get; set; }
        public string Predstoviteli { get; set; }
        public ObservableCollection<KeyWordItem> KeyWords { get; set; } = new ObservableCollection<KeyWordItem>();
        public string Description { get; set; }

    }
}
