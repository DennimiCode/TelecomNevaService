namespace TelecomNevaService.Desktop.Models;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ClientRate")]
public partial class ClientRate
{
    public int ID { get; set; }

    public int PersonalAccountNumber { get; set; }

    public int RateID { get; set; }

    public virtual ContractInfo ContractInfo { get; set; }

    public virtual Rate Rate { get; set; }
}
