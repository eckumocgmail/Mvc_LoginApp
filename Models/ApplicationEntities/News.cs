using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

    public class News 
    {
        public int ID { get; set; }


        [DisplayName("Заголовок")]
        [Required(ErrorMessage = "Необходимо указать заголовок сообщения")]
        public string Title { get; set; }


        [DisplayName("Время")]
        [DataType(DataType.DateTime)]
        public DateTime Time { get; set; }


        [DisplayName("Изображение")]
        public int? ImageID { get; set; }
        public virtual Resource Image { get; set; }


        [DisplayName("URL")]
        [Url(ErrorMessage = "Значение не является URL адресом ресурса")]
        public string Href { get; set; }


        [DisplayName("Описание")]
        [Required(ErrorMessage = "Необходимо ввести описание")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
    }
