using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// Справочник ( дополнительная информация, не обрабатываеся приложением )
/// </summary>
public class DictionaryTable : NamedObject
{
    public static IEnumerable<string> GetTargetObjects<TDictionary>() where TDictionary : Dictionary<string, object>
    {
        throw new NotImplementedException();
    }
}