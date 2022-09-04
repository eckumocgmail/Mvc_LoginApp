using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDb.Entities
{
    public class Calendar
    {       
        [Key]
        public int ID { get; set; }


        [DisplayName("День")]
        public int Day { get; set; }

        [DisplayName("Неделя")]
        public int Week { get; set; }

        [DisplayName("Месяц")]
        public int Month { get; set; }

        [DisplayName("Квартал")]
        public int Quarter { get; set; }

        [DisplayName("Год")]
        public int Year { get; set; }



        [DisplayName("Unix-время")]
        public long Timestamp { get; set; }
    }
}
