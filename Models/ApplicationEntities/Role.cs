using ApplicationDb.Types;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

    public partial class Role: HierDictionaryTable<Role>
    {
        public Role()
        {
            Users = new List<User>();
        }

        [Key]
        public int ID { get; set; }




        [DisplayName("Описание")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Необходимо указать описание роли")]
        public string Description { get; set; }


        [DisplayName("Пользователи")]        
        public virtual List<User> Users { get; set; }


        [DisplayName("Кодовое наименование")]
        [Required(ErrorMessage = "Необходимо указать код роли")]
        public string Code { get; set; }

        public string GetArea()
        {
            return Code + "Face";
        }


    }
