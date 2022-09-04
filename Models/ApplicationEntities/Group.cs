using ApplicationDb.Types;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


/// <summary>
/// Группа пользователей
/// </summary>
public partial class Group: DimensionTable
{
     
    [Key]
    public int ID { get; set; }

    [DisplayName("Наименование")]
    [Required(ErrorMessage = "Необходимо указать наименование")]
    public string Name { get; set; }


    [Required(ErrorMessage = "Необходимо ввести подробное описание")]
    [DataType(DataType.MultilineText)]
    public string Description { get; set; }
       
}


public partial class UserGroups
{
    public int ID { get; set; }
    public int UserID { get; set; }
    public virtual User User { get; set; }
    public int GroupID { get; set; }
    public virtual Group Group { get; set; }
}