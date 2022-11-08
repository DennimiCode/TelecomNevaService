namespace TelecomNevaService.Desktop.Models;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Interface")]
public partial class Interface
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Interface()
    {
        InterfaceAccessNetworkEquipment = new HashSet<InterfaceAccessNetworkEquipment>();
    }

    public int ID { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<InterfaceAccessNetworkEquipment> InterfaceAccessNetworkEquipment { get; set; }
}
