using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
 
public class NamedObject: BaseEntity
{
    [DisplayName("Наименование")]
    [Required(ErrorMessage = "Необходимо указать наменование")]
    public string Name { get; set; }

    [DisplayName("Определение")]
    [DataType(DataType.MultilineText)]
    public string Description { get; set; }
}
 