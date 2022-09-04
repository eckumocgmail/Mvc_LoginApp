using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ApplicationDb.Types
{
    public class HierDictionaryTable<T>: DictionaryTable
    {

        [DisplayName("Корневой каталог")]
        public int? ParentID { get; set; }
        public virtual T Parent { get; set; }

        public string GetPath(string separator)
        {
            HierDictionaryTable<T> parentHier = ((HierDictionaryTable<T>)((object)Parent));
            return (Parent != null) ? parentHier.GetPath(separator) + separator + Name : Name;
        }
    }
}
