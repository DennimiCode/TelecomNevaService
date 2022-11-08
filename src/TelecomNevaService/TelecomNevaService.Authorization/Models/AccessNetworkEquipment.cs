namespace TelecomNevaService.Authorization.Models;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("AccessNetworkEquipment")]
public partial class AccessNetworkEquipment
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public AccessNetworkEquipment()
    {
        InterfaceAccessNetworkEquipment = new HashSet<InterfaceAccessNetworkEquipment>();
    }

    public int ID { get; set; }

    public int EquipmentID { get; set; }

    public int PortsCount { get; set; }

    public int DataTransmissonStandartID { get; set; }

    public decimal Frequency { get; set; }

    public int DataTransmissonSpeed { get; set; }

    [Column(TypeName = "ntext")]
    [Required]
    public string Location { get; set; }

    public virtual DataTransmissionStandart DataTransmissionStandart { get; set; }

    public virtual Equipment Equipment { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<InterfaceAccessNetworkEquipment> InterfaceAccessNetworkEquipment { get; set; }
}
