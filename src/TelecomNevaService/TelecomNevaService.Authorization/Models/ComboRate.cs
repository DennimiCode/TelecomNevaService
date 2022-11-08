namespace TelecomNevaService.Authorization.Models;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ComboRate")]
public partial class ComboRate
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public ComboRate()
    {
        ClientComboRate = new HashSet<ClientComboRate>();
    }

    public int ID { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [Column(TypeName = "ntext")]
    [Required]
    public string Conditions { get; set; }

    public decimal Cost { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<ClientComboRate> ClientComboRate { get; set; }
}
