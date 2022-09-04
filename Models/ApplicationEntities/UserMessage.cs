using ApplicationDb.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

public class UserMessage
{
    [Key]
    public int ID { get; set; }
        
    public int FromUserID { get; set; }        
        

    [ForeignKey("ToUser")]
    public int ToUserID { get; set; }        
    public virtual User ToUser { get; set; }


    [Display(Name = "Создано")]
        
    public DateTime Created { get; set; }

    [Required(ErrorMessage = "Необходимо указать тему сообщения")]
    public string Subject { get; set; }


    [DataType(DataType.MultilineText)]
    [Required(ErrorMessage = "Необходимо ввести текст сообщения")]
    public string Text { get; set; }
}
