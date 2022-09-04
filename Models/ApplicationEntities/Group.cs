using ApplicationDb.Types;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
