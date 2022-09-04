using ApplicationDb.Types;

using System.ComponentModel.DataAnnotations;

public class Login: FactsTable
{
    [Key]
    public int ID { get; set; }

    public int UserID { get; set; }
    public virtual User User { get; set; }


}
