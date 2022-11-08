namespace TelecomNevaService.Authorization.Models;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ContractTerminationReason")]
public partial class ContractTerminationReason
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public ContractTerminationReason()
    {
        ContractInfo = new HashSet<ContractInfo>();
    }

    public int ID { get; set; }

    [Required]
    [StringLength(150)]
    public string Name { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<ContractInfo> ContractInfo { get; set; }
}
