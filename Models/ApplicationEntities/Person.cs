using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

    public class Person
    {


        [Key]
        public int ID { get; set; }

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Не указана фамилия пользователя")]        
        [RegularExpression(@"^[а-яА-ЯёЁ]+$", ErrorMessage = "Фамилия может содержать только буквы русского алфавита")]
        public string SurName { get; set; }


        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Не указано имя пользователя")]        
        [RegularExpression(@"^[а-яА-ЯёЁ]+$", ErrorMessage = "Имя может содержать только буквы русского алфавита")]
        public string FirstName { get; set; }


        [Display(Name = "Отчество")]
        [Required(ErrorMessage = "Не указано отчество пользователя")]        
        [RegularExpression(@"^[а-яА-ЯёЁ]+$", ErrorMessage = "Отчество может содержать только буквы русского алфавита")]
        public string LastName { get; set; }


        [Display(Name = "Дата рождения")]
        [DataType(DataType.Date)]        
        [Required(ErrorMessage = "Не указана дата рождения пользователя")]
        public DateTime Birthday { get; set; }

        [Phone]
        [Display(Name = "Номер телефона")]                
        [Required(ErrorMessage = "Не указана номер телефона")]
        public string Tel { get; set; }

        


        public string GetFullName()
        {
            return $"{SurName} {FirstName} {LastName}";
        }


    }
