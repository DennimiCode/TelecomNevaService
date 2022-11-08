namespace TelecomNevaService.Desktop.Models;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("WirelessCommunicationStandart")]
public partial class WirelessCommunicationStandart
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public WirelessCommunicationStandart()
    {
        BaseStation = new HashSet<BaseStation>();
    }

    public int ID { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<BaseStation> BaseStation { get; set; }
}
