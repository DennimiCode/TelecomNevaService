namespace TelecomNevaService.Authorization.Models;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("Rate")]
public partial class Rate
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Rate()
    {
        ClientRate = new HashSet<ClientRate>();
    }

    public int ID { get; set; }

    public int ServiceID { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; }

    [Column(TypeName = "ntext")]
    [Required]
    public string Conditions { get; set; }

    public decimal Cost { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<ClientRate> ClientRate { get; set; }

    public virtual Service Service { get; set; }
}
