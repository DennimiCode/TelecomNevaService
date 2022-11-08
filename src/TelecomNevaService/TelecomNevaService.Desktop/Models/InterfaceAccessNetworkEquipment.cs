namespace TelecomNevaService.Desktop.Models;
using System.ComponentModel.DataAnnotations.Schema;

[Table("InterfaceAccessNetworkEquipment")]
public partial class InterfaceAccessNetworkEquipment
{
    public int ID { get; set; }

    public int AccessNetworkEquipmentID { get; set; }

    public int InterfaceID { get; set; }

    public virtual AccessNetworkEquipment AccessNetworkEquipment { get; set; }

    public virtual Interface Interface { get; set; }
}
