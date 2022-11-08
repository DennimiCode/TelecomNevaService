namespace TelecomNevaService.Authorization.Models;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("DataTransmissionStandart")]
public partial class DataTransmissionStandart
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public DataTransmissionStandart()
    {
        AccessNetworkEquipment = new HashSet<AccessNetworkEquipment>();
        ClientEquipment = new HashSet<ClientEquipment>();
    }

    public int ID { get; set; }

    [Required]
    [StringLength(250)]
    public string Name { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<AccessNetworkEquipment> AccessNetworkEquipment { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<ClientEquipment> ClientEquipment { get; set; }
}
