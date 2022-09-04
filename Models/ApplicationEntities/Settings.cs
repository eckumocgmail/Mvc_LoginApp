 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

    public partial class Settings
    {
 
        [Key]
        public int ID { get; set; }


        [DisplayName("Передвать новости на электронную почту")]
        public bool SendNewsToEmail { get; set; }

 

}
