namespace TelecomNevaService.Desktop.Models;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Equipment")]
public partial class Equipment
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Equipment()
    {
        AccessNetworkEquipment = new HashSet<AccessNetworkEquipment>();
        HighwayEquipment = new HashSet<HighwayEquipment>();
    }

    public int ID { get; set; }

    [Required]
    [StringLength(300)]
    public string SerialNumber { get; set; }

    public int EquipmentTypeID { get; set; }

    [Column(TypeName = "ntext")]
    [Required]
    public string Name { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<AccessNetworkEquipment> AccessNetworkEquipment { get; set; }

    public virtual EquipmentType EquipmentType { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<HighwayEquipment> HighwayEquipment { get; set; }
}
