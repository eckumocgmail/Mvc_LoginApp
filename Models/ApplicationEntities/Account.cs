using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

/// <summary>
/// Ученая запись пользователя
/// </summary>
[Description("Ученая запись пользователя")]
[DisplayName("Ученая запись пользователя")]
public class Account
{
    [Key]
    public int ID { get; set; }

    [Display(Name = "Электронный адрес")]
    [DataType(
        DataType.EmailAddress,
        ErrorMessage = "Электронный адрес задан некорректно"
    )]

    [NotNull]
    [Required(ErrorMessage = "Не указан электронный адрес")]
    public string Email { get; set; }
    public string Password { get; set; }


    [Description("Если дата не задана значит активация ни разу не выполнена")]
    [AllowNull]      
    [DataType(DataType.Date)]
    public DateTime? Activated { get; set; }

        
    public string ActivationKey { get; set; }

    [NotNull]
    public string Hash { get; set; }

    /// <summary>
    /// Код устройства
    /// </summary>
    public string RFID { get; set; } 
}
