namespace TelecomNevaService.Desktop.Models;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ClientComboRate")]
public partial class ClientComboRate
{
    public int ID { get; set; }

    public int PersonalAccountNumber { get; set; }

    public int ComboRateID { get; set; }

    public virtual ComboRate ComboRate { get; set; }

    public virtual ContractInfo ContractInfo { get; set; }
}
