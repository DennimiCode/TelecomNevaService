namespace TelecomNevaService.Desktop.Models;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ClientEquipment")]
public partial class ClientEquipment
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public ClientEquipment()
    {
        ClientEquipmentPort = new HashSet<ClientEquipmentPort>();
    }

    public int ID { get; set; }

    public int EquipmentID { get; set; }

    public int DataTransmissonStandartID { get; set; }

    public int DataTransmissonSpeed { get; set; }

    [Required]
    [StringLength(100)]
    public string ClientAddress { get; set; }

    public virtual ClientAdress ClientAdress { get; set; }

    public virtual DataTransmissionStandart DataTransmissionStandart { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<ClientEquipmentPort> ClientEquipmentPort { get; set; }
}
