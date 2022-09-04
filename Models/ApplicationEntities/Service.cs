using ApplicationDb.Types;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Обьект модели данных службы сеансов
    /// </summary>
    public class Service: ActiveObject
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Наименование")]
        [Required(ErrorMessage = "Не указано наименование сервиса")]
        public string Name { get; set; }



        [Display(Name = "URL-адрес")]
        [Required(ErrorMessage = "Не указан URL-адрес")]
        public string URL { get; set; }


        [Required]
        public string Hash { get; set; }
    }
