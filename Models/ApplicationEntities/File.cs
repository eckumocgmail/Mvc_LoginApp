using System.ComponentModel.DataAnnotations;

public class File: NamedObject
{
    [Display(Name = "Файл")]
    public byte[] Data { get; set; }
    public string ContentType { get; set; } = "image/png";
}
 