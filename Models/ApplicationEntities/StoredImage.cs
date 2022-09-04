using System.ComponentModel.DataAnnotations;

public class StoredImage
{
    [Key]

    public int ID { get; set; }

    public string ContentType { get; set; } = "image/png";

    [Display(Name = "Файл")]
    public byte[] Data { get; set; }


    [Required(ErrorMessage = "Необходимо указать наименование")]
    [Display(Name = "Название")]
    public string Name { get; set; }


    [Display(Name = "Описание")]
    [DataType(DataType.MultilineText)]
    public string Desc { get; set; }


}
 