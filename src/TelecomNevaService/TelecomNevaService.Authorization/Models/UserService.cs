namespace TelecomNevaService.Authorization.Models;
using System.ComponentModel.DataAnnotations.Schema;

[Table("UserService")]
public partial class UserService
{
    public int ID { get; set; }

    public int PersonalAccountNumber { get; set; }

    public int ServiceID { get; set; }

    public virtual ContractInfo ContractInfo { get; set; }

    public virtual Service Service { get; set; }
}
