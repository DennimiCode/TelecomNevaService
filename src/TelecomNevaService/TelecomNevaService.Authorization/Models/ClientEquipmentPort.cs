namespace TelecomNevaService.Authorization.Models;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ClientEquipmentPort")]
public partial class ClientEquipmentPort
{
    public int ID { get; set; }

    public int PortTypeID { get; set; }

    public int ClientEquipmentID { get; set; }

    public virtual ClientEquipment ClientEquipment { get; set; }

    public virtual PortType PortType { get; set; }
}
