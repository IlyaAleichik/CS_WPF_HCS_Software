using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKP.Model
{
    public class KeyWordItem : BaseViewModel
    {
        public string Value { get; set; }

        public KeyWordItem(string value)
        {
            Value = value;
        }
    }
}
